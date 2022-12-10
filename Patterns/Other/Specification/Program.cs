// Specification
// Позволяет проверять, соответствуют ли объекты определенным требованиям
// Спецификации можно переиспользовать и комбинировать для проверки на соответствие сложным требованиям.

using LearnDotNet.Specification;

var nums = new[] { 1, 2, 4, 8, 16, 32, 64, 128 };

var linqExtensionSpecResult = nums.GreaterThan10().LessThan100().ToArray();
Console.WriteLine($"{nameof(linqExtensionSpecResult)}: {string.Join(",", linqExtensionSpecResult)}");

var lessThan100Specification = new LessThan100Specification();
var greaterThan10Specification = new GreaterThan10Specification();
var compositeSpecification = lessThan100Specification.And(greaterThan10Specification);

var compositeSpecResult = nums.Where(x=> compositeSpecification.IsSatisfiedBy(x)).ToArray();
Console.WriteLine($"{nameof(compositeSpecResult)}: {string.Join(",", compositeSpecResult)}");
