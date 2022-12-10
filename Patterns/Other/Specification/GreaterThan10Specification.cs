namespace LearnDotNet.Specification;

internal sealed class GreaterThan10Specification : CompositeSpecification<int>
{
    public override bool IsSatisfiedBy(int candidate) => candidate > 10;
}