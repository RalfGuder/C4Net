using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;

namespace C4Net.Core.Accessor
{
    public static class ObjectProxyBuilder
    {
        private static TypeBuilder GetTypeBuilder(Type type)
        {
            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = Guid.NewGuid().ToString();
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName.Name);
            TypeBuilder result = moduleBuilder.DefineType("_" + type.Name + "Proxy", TypeAttributes.Public, null, new Type[] { typeof(IObjectProxyAlias) });
            result.AddInterfaceImplementation(typeof(IObjectProxyAlias));
            return result;
        }

        private static ILGenerator GeneratePublicMethod(TypeBuilder typeBuilder, string name, Type returnType, Type[] parameters)
        {
            MethodBuilder methodBuilder = typeBuilder.DefineMethod(name, MethodAttributes.Public, CallingConventions.Standard, returnType, parameters);
            return methodBuilder.GetILGenerator();
        }

        private static void GenerateConstructor(TypeBuilder builder)
        {
            builder.DefineDefaultConstructor(MethodAttributes.Public);
        }

        private static void GenerateCreateObject(TypeBuilder typeBuilder, Type objectType)
        {
            // Inject method CreateObject, returns object, no parameters.
            ILGenerator generator = GeneratePublicMethod(typeBuilder, "CreateObject", typeof(object), null);
            // Generate new objectType()
            generator.Emit(OpCodes.Newobj, objectType.GetConstructor(new Type[0]));
            generator.Emit(OpCodes.Ret);
        }

        private static void GenerateCreateCollection(TypeBuilder typeBuilder, Type collectionType)
        {
            // Inject method CreateCollection, returns ICollection, no parameters.
            ILGenerator generator = GeneratePublicMethod(typeBuilder, "CreateCollection", typeof(ICollection), null);
            // Generate new collectionType()
            generator.Emit(OpCodes.Newobj, collectionType.GetConstructor(new Type[0]));
            generator.Emit(OpCodes.Ret);
        }

        private static void GenerateGetValue(TypeBuilder typeBuilder, Type type)
        {
            ILGenerator generator = GeneratePublicMethod(typeBuilder, "GetValue", typeof(object), new Type[] { typeof(object), typeof(string) });
            // Get the object argument and test if implements the given type.
            generator.Emit(OpCodes.Ldarg_1);           
            generator.Emit(OpCodes.Isinst, type);
            LocalBuilder varType = generator.DeclareLocal(type);
            generator.Emit(OpCodes.Stloc, varType);
        }

        private static void GenerateSetValue(TypeBuilder typeBuilder)
        {
        }

        public static IObjectProxyAlias GenerateProxy(Type type, Type objectType, Type collectionType)
        {
            TypeBuilder typeBuilder = GetTypeBuilder(type);
            GenerateConstructor(typeBuilder);
            // Members of IObjectCreator
            GenerateCreateObject(typeBuilder, objectType);
            GenerateCreateCollection(typeBuilder, collectionType);
            // Members of IObjectAccessor
            GenerateGetValue(typeBuilder, type);
            GenerateSetValue(typeBuilder);
            // Members of IObjectProxy
            // Members of IObjectProxyAlias
            return null;
        }
    }
}
