namespace SM.Shared.Extensions
{
    public static class CollectionExtensions
    {
        public static bool NotNullOrEmpty<T>(this IEnumerable<T> list)
           => list != null && list.Any();

        public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> source, IDictionary<TKey, TValue> data)
        {
            if (source == null || !data.NotNullOrEmpty())
                return;

            foreach (var item in data)
                if (!source.ContainsKey(item.Key))
                    source.Add(item.Key, item.Value);
        }

        public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> source, params IDictionary<TKey, TValue>[] datas)
        {
            if (source == null || !datas.NotNullOrEmpty())
                return;

            foreach (var data in datas)
                source.Merge(data);
        }
    }
}
