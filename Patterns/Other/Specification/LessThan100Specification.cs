namespace LearnDotNet.Specification;

internal sealed class LessThan100Specification : CompositeSpecification<int>
{
    public override bool IsSatisfiedBy(int candidate) => candidate < 100;
}