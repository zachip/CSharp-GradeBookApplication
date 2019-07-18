using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool weight) : base(name, weight)
        {
            IsWeighted = weight;
            Type = GradeBookType.Standard;
        }
    }
}
