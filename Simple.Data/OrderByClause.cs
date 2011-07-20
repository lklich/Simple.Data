namespace Simple.Data
{
    /// <summary>
    /// Represents the ordering clause of a <see cref="SimpleQuery"/>.
    /// There may be zero, one or multiple instances of this type in <see cref="SimpleQuery.Clauses"/>; the order in that list should be treated as significant.
    /// </summary>
    public class OrderByClause : SimpleQueryClauseBase
    {
        private readonly ObjectReference _reference;
        private readonly OrderByDirection _direction;

        public OrderByClause(ObjectReference reference) : this(reference, OrderByDirection.Ascending)
        {
        }

        public OrderByClause(ObjectReference reference, OrderByDirection direction)
        {
            _reference = reference;
            _direction = direction;
        }

        public OrderByDirection Direction
        {
            get { return _direction; }
        }

        public ObjectReference Reference
        {
            get { return _reference; }
        }

    }
}