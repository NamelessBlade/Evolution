namespace Evolution;

enum AlleleType
{
    Body,
    Eye,
    Red,
    Blue,
    Green
}

enum BodyShapes : int
{
    TwoLegs = 0,
    FourLegs = 1
}

enum EyeShape : int
{
    OneEye = 0,
    TwoEyes = 1,
    ThreeEyes = 2
}

    
interface IAllele
{
    AlleleType AlleleType { get; }
    bool IsDominant(IAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary);
    IAllele Mutate();
}

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

class BodyAllele(BodyShapes _bodyType) : IAllele
{
    public bool IsDominant(IAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        if (comparedAllele is BodyAllele bodyComparedAllele)
        {
            int[] dominanceOrder = dominanceDictionary[AlleleType];
            int ownPositionInDominance = dominanceOrder.IndexOf((int)bodyType);
            int comparedPositionInDominance = dominanceOrder.IndexOf((int)bodyComparedAllele.bodyType);

            if (ownPositionInDominance > comparedPositionInDominance)
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
        return new BodyAllele((BodyShapes)Random.Shared.Next(0, 2));
    }
    public AlleleType AlleleType => AlleleType.Body;
    public BodyShapes bodyType { get; } = _bodyType;
}

class EyeAllele(EyeShape _eyeType) : IAllele
{
    public bool IsDominant(IAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        if (comparedAllele is EyeAllele eyeComparedAllele)
        {
            int[] dominanceOrder = dominanceDictionary[AlleleType];
            int ownPositionInDominance = dominanceOrder.IndexOf((int)eyeType);
            int comparedPositionInDominance = dominanceOrder.IndexOf((int)eyeComparedAllele.eyeType);

            if (ownPositionInDominance > comparedPositionInDominance)
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
        return new EyeAllele((EyeShape)Random.Shared.Next(0, 3));
    }
    public AlleleType AlleleType => AlleleType.Eye;
    public EyeShape eyeType { get; } = _eyeType;
}
