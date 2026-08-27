namespace Evolution.Allele;

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
