namespace Evolution.Allele;

class GreenAllele(Byte _colourPair) : IAllele
{
    public bool IsDominant(IAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        if (comparedAllele is GreenAllele greenComparedAllele)
        {
            Byte dominantValue = (byte)dominanceDictionary[AlleleType][0];
            if (Math.Abs(colourPair - dominantValue) > Math.Abs(greenComparedAllele.colourPair - dominantValue))
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
        return new GreenAllele((Byte)Random.Shared.Next(0, 256));
    }
    public AlleleType AlleleType => AlleleType.Green;
    public Byte colourPair { get; } = _colourPair;

}
