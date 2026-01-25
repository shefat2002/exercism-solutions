public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate) => collection.Where(predicate);
    

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)  => collection.Where(item => !predicate(item));
}