namespace Evolution;

class Creature
{
    public List<AllelePair> Geneome { get; } = [];

    public Creature(IAllele[] geneome1, IAllele[] geneome2)
    {
        foreach (IAllele Allele in geneome1)
        {
            IAllele matchingAllele = geneome2.FirstOrDefault(n => n.AlleleType == Allele.AlleleType) ?? throw new InvalidOperationException();
            
            Geneome.Append(new AllelePair(Allele, matchingAllele));
        }
        
    }

    public List<IAllele> GenerateCreaturePhenotype() => [.. Geneome.Select(gene => gene.GetDominantAllele())];

    public List<IAllele> GenerateGeneomeForBreeding()
    {
        List<IAllele> chosenChildGeneome = [];
        foreach (AllelePair gene in Geneome)
        {
            switch (Random.Shared.Next(0, 101)){
                case 1:
                    chosenChildGeneome.Append(gene.firstAllele.Mutate());
                    break;
                default:
                    chosenChildGeneome.Append(gene.GetRandomAlleleFromPair());
                    break;
            }
            
        }
            
        return chosenChildGeneome;
    }

}