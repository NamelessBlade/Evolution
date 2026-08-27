namespace Evolution.Allele;

class RedAllele(Byte _colourPair) : IAllele
{
    public bool IsDominant(IAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {

        if (comparedAllele is RedAllele redComparedAllele)
        {

            Byte dominantValue = (byte)dominanceDictionary[AlleleType][0];
            if (Math.Abs(colourPair - dominantValue) > Math.Abs(redComparedAllele.colourPair - dominantValue))
                return false;
            else
                return true;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public IAllele Mutate()
    {
        return new RedAllele((Byte)Random.Shared.Next(0,256));
    }

    public AlleleType AlleleType => AlleleType.Red;
    public Byte colourPair { get; } = _colourPair;

}
