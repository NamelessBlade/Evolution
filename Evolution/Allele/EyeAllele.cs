namespace Evolution.Allele;

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
