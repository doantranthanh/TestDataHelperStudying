using System;

namespace OriginalTestDataBuilders
{
    public class BuilderGeneric<T>
    {
        private readonly T item;

        public BuilderGeneric(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.item = item;
        }

        public BuilderGeneric<T1> Select<T1>(Func<T, T1> f)
        {
            var newItem = f(this.item);
            return new BuilderGeneric<T1>(newItem);
        }

        public T Build()
        {
            return this.item;
        }

        public override bool Equals(object obj)
        {
            var other = obj as BuilderGeneric<T>;
            if (other == null)
            {
                return base.Equals(obj);
            }

            return object.Equals(this.item, other.item);
        }

        public override int GetHashCode()
        {
            return this.item.GetHashCode();
        }

        public static implicit operator T(BuilderGeneric<T> b)
        {
            return b.item;
        }
    }
}
