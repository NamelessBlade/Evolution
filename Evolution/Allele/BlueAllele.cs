namespace Evolution.Allele;

class BlueAllele(Byte _colourPair) : IAllele
{
    public bool IsDominant(IAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        if (comparedAllele is BlueAllele blueComparedAllele)
        {
            Byte dominantValue = (byte)dominanceDictionary[AlleleType][0];
            if (Math.Abs(colourPair - dominantValue) > Math.Abs(blueComparedAllele.colourPair - dominantValue))
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
        return new BlueAllele((Byte)Random.Shared.Next(0, 256));
    }

    public AlleleType AlleleType => AlleleType.Blue;
    public Byte colourPair { get; } = _colourPair;

}
