namespace Evolution.Allele;

interface IAllele
{
    AlleleType AlleleType { get; }
    bool IsDominant(IAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary);
    IAllele Mutate();
}
