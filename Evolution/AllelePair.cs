using Evolution.Allele;

namespace Evolution;
class AllelePair
{
    public IAllele firstAllele {  get; }
    private readonly IAllele secondAllele;

    public AllelePair(IAllele _firstAllele, IAllele _secondAllele)
    {
        firstAllele = _firstAllele;
        secondAllele = _secondAllele;
    }

    public IAllele GetRandomAlleleFromPair()
    {
        return Random.Shared.Next(0, 2) switch
        {
            0 => firstAllele,
            1 => secondAllele,
            _ => firstAllele,
        };
    }

    public IAllele GetDominantAllele(Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        if (firstAllele.IsDominant(secondAllele, dominanceDictionary))
            return firstAllele;
        else
            return secondAllele;
    }
}