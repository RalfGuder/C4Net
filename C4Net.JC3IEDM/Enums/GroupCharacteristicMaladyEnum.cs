using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that identifies the type of ill health, ailment or disease in a specific GROUP-CHARACTERISTIC.
    /// </summary>
    [DomId(100004154)]
    [DataContract]
    public enum GroupCharacteristicMaladyEnum
    {
		
        /// <summary>
        /// Any of several diseases caused by a trypanosome and usually transmitted by biting insects, including sleeping sickness and Chagas' disease.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AFRTRP")]
        [EnumMember]
        AfricanTrypanosomiasis,
		
        /// <summary>
        /// Acquired immune deficiency syndrome, a condition caused by a virus transmitted in the body fluids, marked by severe loss of resistance to infection and so ultimately fatal.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIDS")]
        [EnumMember]
        AidsHiv,
		
        /// <summary>
        /// An acute inflammatory amebiasis of the colon, marked by severe pain and diarrhoea and caused by the amoeba Entamoeba Histolytica.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AMBDYS")]
        [EnumMember]
        AmebiasisAmoebicDysentry,
		
        /// <summary>
        /// A bacterial disease caused by the spore-forming Bacillus anthracis, a Gram positive, rod-shaped bacterium. There are 3 types of anthrax in humans: cutaneous anthrax, acquired when a spore enters the skin through a cut or an abrasion; gastrointestinal tract anthrax, contracted from eating contaminated food, primarily meat from an animal that died of the disease; and pulmonary (inhalation) anthrax from breathing in airborne anthrax spores.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ANTHRX")]
        [EnumMember]
        Anthrax,
		
        /// <summary>
        /// Antimicrobial resistance, a condition encouraged by agricultural and animal uses of drugs and is due to under-use of drugs in poorer countries and over-use in wealthy countries.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ANTMRS")]
        [EnumMember]
        AntimicrobialResistance,
		
        /// <summary>
        /// Viruses that are maintained in nature principally, or to an important extent, through biological transmission between susceptible vertebrate hosts by haematophagous arthropods; they multiply and produce viraemia in the vertebrates, multiply in the tissues of arthropods and are passed on to the new vertebrates by the bites of arthropod after a period of extrinsic incubation. Examples are Dengue and Yellow Fever.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ARBVRS")]
        [EnumMember]
        ArbovirusInfectionNec,
		
        /// <summary>
        /// Botulism is an intoxication caused by extremely potent toxins produced by the bacterium Clostridium botulinum preformed in foods.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("BOTULM")]
        [EnumMember]
        Botulism,
		
        /// <summary>
        /// A disease caused by bacteria of the genus Brucella usually transmitted from animals to man through ingestion, contact, inhalation or inoculation.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("BRUCLS")]
        [EnumMember]
        Brucellosis,
		
        /// <summary>
        /// A Mycobacterium ulcerans, whose source is unknown, that causes painless swelling in the skin and causes severely deforming ulcers.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("BURULI")]
        [EnumMember]
        BuruliUlcer,
		
        /// <summary>
        /// Campylobacters are bacteria that are a major cause of diarrhoeal illness in humans and are generally regarded as the most common bacterial cause of gastroenteritis worldwide. Campylobacteriosis is the disease caused by the presence of campylobacters.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CAMPLB")]
        [EnumMember]
        Campylobacter,
		
        /// <summary>
        /// A disease caused by trypanosomes transmitted by bloodsucking bugs, endemic in S. America and causing damage to the heart and central nervous system.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("CHAGAS")]
        [EnumMember]
        ChagasDisease,
		
        /// <summary>
        /// A genital ulcer disease caused by the Gram-negative bacillus H. ducreyi and results in superficial ulcerations, often with suppurant regional lymphadenopathy.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("CHANCR")]
        [EnumMember]
        Chancroid,
		
        /// <summary>
        /// An acute contagious viral disease, usually of young children, characterised by skin eruption and a slight fever.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("CHCKPX")]
        [EnumMember]
        ChickenPox,
		
        /// <summary>
        /// A virus-like bacterium of the genus Chlamydia, which comprises Gram-negative coccoids that reproduce as intracellular parasites in vertebrates and occasionally anthropods and is classified as a major cause of sexually transmited diseases (STDs).
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("CHLMDA")]
        [EnumMember]
        Chlamydia,
		
        /// <summary>
        /// An infectious and often fatal disease of the small intestine caused by the mainly water-borne bacterium Vibrio cholerae, resulting in severe vomiting and diarrhoea.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("CHOLRA")]
        [EnumMember]
        CholeraEpidemicDysentery,
		
        /// <summary>
        /// A fungus disease that usually affects the lungs of humans and other animals, caused by the fungus Coccidioides immitis.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("COCCID")]
        [EnumMember]
        Coccidioidomycosis,
		
        /// <summary>
        /// Croup is a viral infection that causes a brassy, barking cough in young children.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("CROUP")]
        [EnumMember]
        Croup,
		
        /// <summary>
        /// A diarrhoeal disease caused by a microscopic parasite, Cryptosporidium parvum. It is one of the most common causes of waterborne disease (drinking and recreational) in humans.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("CRYPTS")]
        [EnumMember]
        Cryptosporidoiosis,
		
        /// <summary>
        /// A parasite composed of one cell, too small to be seen without a microscope. Cyclospora is spread by people ingesting something, for example, water or food that was contaminated with infected stool.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("CYCLSP")]
        [EnumMember]
        Cyclospora,
		
        /// <summary>
        /// An infectious viral disease of the tropics, transmitted by mosquitoes and causing a fever and acute pains in the joints.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("DENGUE")]
        [EnumMember]
        Dengue,
		
        /// <summary>
        /// Diphtheria is a bacterial infection caused by Corynebacterium diphtheriae, and can occur as a toxic or nontoxic strain. It spreads through close contact with a person infected with diphtheria.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("DIPTHR")]
        [EnumMember]
        Diptheria,
		
        /// <summary>
        /// A chronic, slowly progressive, mildly contagious disease of venereal origin, characterized by granulomatous ulceration of the genitalia and neighboring sites, with little or no tendency to spontaneous healing.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("DONOVA")]
        [EnumMember]
        Donovanosis,
		
        /// <summary>
        /// A parasitic disease caused by the parasitic worm Drarunculus medinensis or "guinea worm".
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("DRACUN")]
        [EnumMember]
        Dracunculiasis,
		
        /// <summary>
        /// A strain of the bacterium Escherichia coli that produces a powerful toxin and can cause severe illness. The infection often causes severe bloody diarrhoea and abdominal cramps; sometimes the infection causes non-bloody diarrhoea or no symptoms. Usually little or no fever is present, and the illness resolves in 5 to 10 days.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("ECOLI")]
        [EnumMember]
        EColi0157H7VerotoxigenicEColi,
		
        /// <summary>
        /// A tick borne disease caused by several bacterial species in the genus Ehrlichia, characterized by fever and swollen lymph nodes.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("EHRLCH")]
        [EnumMember]
        Ehrlichiosis,
		
        /// <summary>
        /// Viruses that are maintained in nature through biological transmission between susceptible vertebrate hosts by blood feeding arthropods (mosquitoes, psychodids, ceratopogonids, and ticks) usually resulting in a brain inflammation.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("ENCPHL")]
        [EnumMember]
        Encephalitis,
		
        /// <summary>
        /// A streptococcal infection of the skin and subcutaneous tissue caused by a streptococcus and marked by spreading inflammation.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("ERYSPL")]
        [EnumMember]
        Erysipelas,
		
        /// <summary>
        /// A tropical disease caused by the presence of filarial worms esp. in the lymph vessels.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("FILARS")]
        [EnumMember]
        Filariasis,
		
        /// <summary>
        /// A rotavirus infection of the stomach and small and large intestines caused by a variety of viruses that results in vomiting or diarrhoea.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("GASTRE")]
        [EnumMember]
        GastroenteritisUnder2SOnly,
		
        /// <summary>
        /// A diarrhoeal disease caused by a microscopic parasite, Giardia intestinalis that lives in the intestine of people and animals. It is one of the most common causes of waterborne disease (drinking and recreational) in humans.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("GIARDS")]
        [EnumMember]
        Giardiasis,
		
        /// <summary>
        /// Gonorrhea, a common sexually transmitted disease (STD), is caused by Neisseria gonorrhoeae, a bacterium that can grow and multiply easily in mucous membranes of the body.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("GONORH")]
        [EnumMember]
        Gonorrhea,
		
        /// <summary>
        /// A bacterial infection and one of the leading causes of bacterial meningitis in children under 5 years of age.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("HINFLZ")]
        [EnumMember]
        HInfluenzaeInvasive,
		
        /// <summary>
        /// Hantaviruses are carried by rodents, especially the deer mouse. You can become infected by exposure to their droppings, and the first signs of sickness (especially fever and muscle aches) appear 1 to 5 weeks later, followed by shortness of breath and coughing. Once this phase begins, the disease progresses rapidly, necessitating hospitalisation and often ventilation within 24 hours.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("HANTAV")]
        [EnumMember]
        HantavirusInfection,
		
        /// <summary>
        /// A severe multisystem syndrome (multisystem in that multiple organ systems in the body are affected).  Characteristically, the overall vascular system is damaged, and the body's ability to regulate itself is impaired.  These symptoms are often accompanied by hemorrhage (bleeding); however, the bleeding is itself rarely life-threatening.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("HEMRHG")]
        [EnumMember]
        HemorrhagicFever,
		
        /// <summary>
        /// A liver disease caused by the hepatitis A virus (HAV).
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("HEPATA")]
        [EnumMember]
        HepatitisA,
		
        /// <summary>
        /// A serious disease caused by a virus that attacks the liver. The virus, which is called hepatitis B virus (HBV), can cause lifelong infection, cirrhosis (scarring) of the liver, liver cancer, liver failure, and death.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("HEPATB")]
        [EnumMember]
        HepatitisB,
		
        /// <summary>
        /// A liver disease caused by the Hepatitis C virus (HCV), which is found in the blood of persons who have the disease. HCV is spread by contact with the blood of an infected person.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("HEPATC")]
        [EnumMember]
        HepatitisC,
		
        /// <summary>
        /// Human Immunodeficiency Virus, either of 2 retroviruses (HIV-1, HIV-2) that causes AIDS.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("HIV")]
        [EnumMember]
        HivInfection,
		
        /// <summary>
        /// A rare smallpox like disease acquired from monkeys or squirrels but does occasionally spread from man to man in unvaccinated communities.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("HMNMPX")]
        [EnumMember]
        HumanMonkeypox,
		
        /// <summary>
        /// A disease that results from being infected with the larval stage of Echinococcus multilocularis, a microscopic tapeworm (1-4 millimeters) found in foxes, coyotes, dogs, and cats.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("HYDATD")]
        [EnumMember]
        HydatidInfection,
		
        /// <summary>
        /// An intestinal inflammation.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("INFENT")]
        [EnumMember]
        InfectiveEnteritis,
		
        /// <summary>
        /// A highly contagious virus infection causing fever, severe aching, and catarrh, often occurring in epidemics.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("INFLUN")]
        [EnumMember]
        Influenza,
		
        /// <summary>
        /// An infection caused by the bacterium Legionella pneumophila usually transmitted by mists that come from a water source (e.g., air conditioning cooling towers, whirlpool spas, showers) contaminated with Legionella bacteria.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("LEGION")]
        [EnumMember]
        Legionellosis,
		
        /// <summary>
        /// Any of several diseases caused by parasitic protozoans of the genus Leishmania transmitted by the bite of sandflies.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("LSHMNA")]
        [EnumMember]
        Leishmaniasis,
		
        /// <summary>
        /// A disease, resulting in skin sores, caused by the parasitic protozoans of the genus Leishmania transmitted by sand flies.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("LSHMNC")]
        [EnumMember]
        LeishmaniasisCutaneous,
		
        /// <summary>
        /// A disease, resulting in sores around the nose or mouth, caused by the parasitic protozoans of the genus Leishmania transmitted by sand flies.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("LSHMNM")]
        [EnumMember]
        LeishmaniasisMucocutaneous,
		
        /// <summary>
        /// A disease, resulting in damage to some of the internal organs of the body (for example, spleen, liver, bone marrow), caused by the parasitic protozoans of the genus Leishmania transmitted by sand flies.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("LSHMNV")]
        [EnumMember]
        LeishmaniasisVisceral,
		
        /// <summary>
        /// A contagious bacterial disease that affects the skin, mucous membranes, and nerves, causing disfigurement.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("LEPRSY")]
        [EnumMember]
        Leprosy,
		
        /// <summary>
        /// Leptospirosis is a bacterial disease that affects humans and animals. It is caused by bacteria of the genus Leptospira found in water contaminated with the urine of infected animals.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("LEPTOS")]
        [EnumMember]
        Leptospirosis,
		
        /// <summary>
        /// A serious infection caused by eating food contaminated with the bacterium Listeria monocytogenes.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("LISTRS")]
        [EnumMember]
        Listeriosis,
		
        /// <summary>
        /// An infectious disease caused by the bacterium, Borrelia burgdorferi, transmitted by the bite of infected deer ticks.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("LYME")]
        [EnumMember]
        LymeDisease,
		
        /// <summary>
        /// A disease, caused by infection with L1, L2, or L3 serovars of Chlamydia trachomatis, usually sexually transmitted, characterized by genital lesions, suppurative regional lymphadenopathy, or hemorrhagic proctitis.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("LYMPHG")]
        [EnumMember]
        LymphogranulomaVenereum,
		
        /// <summary>
        /// An intermittent and remittent fever caused by a protozoan parasite of the genus Plasmodium, introduced by the bite of a mosquito.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("MALARA")]
        [EnumMember]
        Malaria,
		
        /// <summary>
        /// An acute infectious viral disease marked by red spots on the skin.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("MEASLS")]
        [EnumMember]
        Measles,
		
        /// <summary>
        /// An infection of the fluid of a person's spinal cord and the fluid that surrounds the brain.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("MENING")]
        [EnumMember]
        Meningitis,
		
        /// <summary>
        /// An infection of the fluid of a person's spinal cord and the fluid that surrounds the brain usually caused by a viral infection.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("MENNGE")]
        [EnumMember]
        MeningitisEncephalisViral,
		
        /// <summary>
        /// An infection of the fluid of a person's spinal cord and the fluid that surrounds the brain usually caused by a bacterial infection.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("MENNGO")]
        [EnumMember]
        MeningitisOtherBacterial,
		
        /// <summary>
        /// An infection of the fluid of a person's spinal cord and the fluid that surrounds the brain usually caused by a Streptococcus pneumoniae bacteria.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("MENNGP")]
        [EnumMember]
        MeningitisPneumonococcal,
		
        /// <summary>
        /// An infection of the fluid of a person's spinal cord and the fluid that surrounds the brain usually caused by a Neisseria meningitidis bacteria.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("MNNGOC")]
        [EnumMember]
        MeningococcalDisease,
		
        /// <summary>
        /// An acute viral illness acquired by respiratory droplets.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("MUMPS")]
        [EnumMember]
        Mumps,
		
        /// <summary>
        /// An illness characterized by fever, chills, headache, photophobia, cough, and myalgia.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("ORNTHS")]
        [EnumMember]
        Ornithosis,
		
        /// <summary>
        /// An acute intestinal disease that resembles typhoid fever and is caused by any of three bacteria of the genus Salmonella.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("PRTPHY")]
        [EnumMember]
        ParatyphoidFever,
		
        /// <summary>
        /// An acute infectious disease (Whooping Cough) caused by the bacterium Bordetella pertussis, a small aerobic gram-negative rod.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("PRTUSS")]
        [EnumMember]
        Pertussis,
		
        /// <summary>
        /// A contagious bacterial disease characterized by fever and delirium, with the formation of buboes (bubonic plague) and sometimes infection of the lungs (pneumonic plague).
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("PLAGUE")]
        [EnumMember]
        Plague,
		
        /// <summary>
        /// A disease that results from the infection of the air passages and lungs by certain germs.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("PNEUMO")]
        [EnumMember]
        PneumoniaPneumococcal,
		
        /// <summary>
        /// Acute onset of a flaccid paralysis of one or more limbs with decreased or absent tendon reflexes in the affected limbs, without other apparent cause, and without sensory or cognitive loss.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("POLIO")]
        [EnumMember]
        Poliomyelitis,
		
        /// <summary>
        /// An infection of the genital tract and of the blood stream after birth.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("PUERPL")]
        [EnumMember]
        PuerperalFever,
		
        /// <summary>
        /// A zoonotic disease caused by Coxiella burnetii, a species of bacteria that is distributed globally.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("QFEVER")]
        [EnumMember]
        QFever,
		
        /// <summary>
        /// A contagious and fatal viral disease of dogs and other mammals, transmissible through the saliva to humans etc. and causing madness and convulsions; hydrophobia.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("RABIES")]
        [EnumMember]
        RabiesHuman,
		
        /// <summary>
        /// An infection caused by the spirochetes Borrelia hermsii and B. turicatae and is transmitted to humans principally by the bites of the infected ticks.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("RLPSNG")]
        [EnumMember]
        RelapsingFever,
		
        /// <summary>
        /// An inflammatory illness that occurs as a delayed sequela of group A streptococcal infection.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("RHEUMA")]
        [EnumMember]
        RheumaticFeverAcute,
		
        /// <summary>
        /// An acute, fever-causing viral disease that affects domestic animals (such as cattle, buffalo, sheep, goats, and camels) and humans. RVF is most commonly associated with mosquito-borne epidemics during years of unusually heavy rainfall.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("RIFTVF")]
        [EnumMember]
        RiftValleyFever,
		
        /// <summary>
        /// A rickettsial illness caused by Rickettsia rickettsii, a species of bacteria that is spread to humans by ixodid (hard) ticks.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("RCKYMT")]
        [EnumMember]
        RockyMountainSpottedFever,
		
        /// <summary>
        /// A mosquito borne virus found only in Australia.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("ROSSRV")]
        [EnumMember]
        RossRiverVirusInfection,
		
        /// <summary>
        /// A virus, also referred to as German Measles, classified as a togavirus, genus Rubivirus.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("RUBELA")]
        [EnumMember]
        Rubella,
		
        /// <summary>
        /// A Rubella infection characterized by congenital cataracts in infants born following maternal rubella infection in early pregnancy.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("RUBELC")]
        [EnumMember]
        RubellaCongenital,
		
        /// <summary>
        /// An infection with a bacterium called Salmonella usually acquired from contaminated food, water, or contact with infected animals.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("SALMNL")]
        [EnumMember]
        Salmonellosis,
		
        /// <summary>
        /// A systematic disease caused by pathogenic organisms or other toxins in the bloodstream.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("SEPTCM")]
        [EnumMember]
        Septicemia,
		
        /// <summary>
        /// A disease caused by a bacteria called group A streptococcus, usually transmitted by contact with the sick person because this germ is carried in the mouth and nasal fluids.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("SCRLET")]
        [EnumMember]
        ScarletFever,
		
        /// <summary>
        /// A parasitic tropical flatworm of the genus Schistosoma, carried by freshwater snails and infesting the blood vessels of birds and mammals, causing bilharzia in humans.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("SCHSTO")]
        [EnumMember]
        SchistosomiasisIntestinalParasites,
		
        /// <summary>
        /// A respiratory illness spread by direct close person-to-person contact with infectious material (for example, respiratory secretions) from a person who has SARS.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("SARS")]
        [EnumMember]
        SevereAcuteRespiratorySyndromeSars,
		
        /// <summary>
        /// Any of various diseases contracted chiefly by sexual intercourse with a person already infected; a sexually transmitted disease.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("SXLTRN")]
        [EnumMember]
        SexuallyTransmittedInfections,
		
        /// <summary>
        /// An infectious disease caused by a group of bacteria called Shigella, usually passing from person to person from stools or soiled fingers of one person to the mouth of another person.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("SHGLLS")]
        [EnumMember]
        Shigellosis,
		
        /// <summary>
        /// An infectious disease caused by the variola virus usually transmitted from person to person or through direct contact with infected bodily fluids or contaminated objects such as bedding or clothing.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("SMLLPX")]
        [EnumMember]
        Smallpox,
		
        /// <summary>
        /// A bacterium often found in the throat and on the skin and spread through direct contact with mucus from the nose or throat of persons who are infected or through contact with infected wounds or sores on the skin.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("STREPT")]
        [EnumMember]
        StreptococcusGroupAInvasive,
		
        /// <summary>
        /// A complex sexually transmitted disease (STD) caused by the bacterium Treponema pallidum usually passed from person to person through direct contact with a syphilis sore. Sores occur mainly on the external genitals, vagina, anus, or in the rectum.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("SYPHLA")]
        [EnumMember]
        SyphilisAll,
		
        /// <summary>
        /// A condition caused by infection in utero with Treponema pallidum. The infection of an infant whose mother had untreated or inadequately treated syphilis at delivery.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("SYPHLC")]
        [EnumMember]
        SyphilisCongenital,
		
        /// <summary>
        /// A subcategory of latent syphilis. When initial infection has occurred within the previous 12 months, latent syphilis is classified as early latent.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("SYPHLE")]
        [EnumMember]
        SyphilisEarlySymptomatic,
		
        /// <summary>
        /// A stage of infection caused by T. pallidum in which organisms persist in the body of the infected person without causing symptoms or signs.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("SYPHLL")]
        [EnumMember]
        SyphilisLatent,
		
        /// <summary>
        /// A stage of infection with Treponema pallidum characterized by one or more chancres (ulcers); chancres might differ considerably in clinical appearance and by localized or diffuse mucocutaneous lesions, often with generalized lymphadenopathy.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("SYPHLP")]
        [EnumMember]
        SyphilisPrimarySecondary,
		
        /// <summary>
        /// An acute, often fatal, disease caused by exotoxin produced by Clostridium tetani. Spores are widely distributed in soil and in the intestines and feces of some animals. Usually enters the body through a wound.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("TETANS")]
        [EnumMember]
        Tetanus,
		
        /// <summary>
        /// A toxin caused syndrome manifested by sudden onset of fever, chills, vomiting, diarrhoea, muscle pains and rash associated with use of tampons and intravaginal contraceptive devices in women and occurs as a complication of skin abscesses or surgery.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("TOXSHK")]
        [EnumMember]
        ToxicShockSyndrome,
		
        /// <summary>
        /// An infection caused by a single-celled parasite called Toxoplasma gondii, usually resulting from accidental ingestion of contaminated cat feces, or ingestion of raw or partly cooked meat, especially pork, lamb, or venison, or by touching your hands to your mouth after handling undercooked meat, or through contamination of knives, utensils, cutting boards and other foods that have had contact with raw meat.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("TOXPLS")]
        [EnumMember]
        Toxoplasmosis,
		
        /// <summary>
        /// A disease of the brain.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("TRNSSP")]
        [EnumMember]
        TransmissibleSpongiformEncephalopathies,
		
        /// <summary>
        /// Caused by eating raw or undercooked pork and wild game products infected with the larvae of a species of worm called Trichinella.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("TRCHNS")]
        [EnumMember]
        Trichinosis,
		
        /// <summary>
        /// A parasite ‘Trypanosoma brucei rhodesiense’ transmitted disease (Sleeping Sickness) caused by the bite of the Tsetse fly.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("TRYPNS")]
        [EnumMember]
        Trypanosomiasis,
		
        /// <summary>
        /// A disease caused by bacteria called Mycobacterium tuberculosis. The bacteria can attack any part of your body, but they usually attack the lungs. It is spread through the air from one person to another.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("TUBERC")]
        [EnumMember]
        TuberculosisPulmonary,
		
        /// <summary>
        /// An infectious disease caused by a hardy bacterium, Francisella tularensis, found in animals (especially rodents, rabbits, and hares). It is contracted through the bite of an infected insect or other arthropod (usually a tick or deerfly), handling infected animal carcasses, eating or drinking contaminated food or water, or breathing in F. tularensis.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("TULARM")]
        [EnumMember]
        Tularemia,
		
        /// <summary>
        /// A life-threatening illness caused by the bacterium Salmonella Typhi, that lives only in humans. It can be contracted if you eat food or drink beverages that have been handled by a person who is shedding S. Typhi or if sewage contaminated with S. Typhi bacteria gets into the water you use for drinking or washing food.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("TYPHOD")]
        [EnumMember]
        TyphoidFever,
		
        /// <summary>
        /// Any of several forms of an infectious disease caused by micro-organisms of the genus Rickettsia, especially when flea-borne as in endemic typhus, louse-borne as in epidemic typhus, or mite-borne as in scrub typhus.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("TYPHUS")]
        [EnumMember]
        TyphusFever,
		
        /// <summary>
        /// Urethral inflammation that is not the result of infection with Neisseria gonorrhoeae.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("URTHRT")]
        [EnumMember]
        UrethritisNonGonococcal,
		
        /// <summary>
        /// A virus of the herpes family that can result in bacterial infection of the skin, swelling of the brain, and pneumonia. It is spread by coughing and sneezing (highly contagious).
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("VARCLL")]
        [EnumMember]
        VaricellaActiveDutyOnly,
		
        /// <summary>
        /// A group of illnesses that are caused by several distinct families of viruses. In general, the term "viral hemorrhagic fever" is used to describe a severe multisystem syndrome.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("VRHAEM")]
        [EnumMember]
        ViralHaemorragicFeversNotOtherwiseSpecified,
		
        /// <summary>
        /// A range of syndromes, including acute dehydrating diarrhoea (cholera), prolonged febrile illness with abdominal symptoms (typhoid fever), acute bloody diarrhoea (dysentery), and chronic diarrhoea (Brainerd diarrhoea). Usually caused by contaminated surface water sources and large poorly functioning municipal water distribution systems.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("WTRBRN")]
        [EnumMember]
        WaterBorneIllness2OrMoreRelatedCases,
		
        /// <summary>
        /// A tropical virus disease with fever and jaundice, transmitted by the mosquito and often fatal.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("YELLWF")]
        [EnumMember]
        YellowFever,
		
        /// <summary>
        /// An infectious disease caused by a bacterium of the genus Yersinia usually acquired by eating contaminated food, especially raw or undercooked pork products.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("YERSNS")]
        [EnumMember]
        YersinosisNec,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
