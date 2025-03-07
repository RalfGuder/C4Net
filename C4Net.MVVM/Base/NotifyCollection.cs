using System.Collections.Specialized;

namespace C4Net.MVVM.Base
{
    public class NotifyCollection : NotifyObject, INotifyCollectionChanged
    {
        #region - Events -

        event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
        {
            add
            {
                CollectionChanged += value;
            }
            remove
            {
                CollectionChanged -= value;
            }
        }

        protected virtual event NotifyCollectionChangedEventHandler CollectionChanged;

        #endregion

        #region - Methods -

        protected virtual void NotifyOfCollectionChange(NotifyCollectionChangedEventArgs args)
        {
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, args);
            }
        }

        protected virtual void NotifyOfCollectionAdd(object item, int index)
        {
            this.NotifyOfCollectionChange(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
        }

        protected virtual void NotifyOfCollectionRemove(object item, int index)
        {
            this.NotifyOfCollectionChange(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
        }

        protected virtual void NotifyOfCollectionClear()
        {
            this.NotifyOfCollectionChange(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        #endregion
    }
}
