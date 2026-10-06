using DO;
using DalApi1;

namespace DalApi1;

public interface IDAl
{
    Istudent student { get; }
    Ianswer answer { get; }
    Iquestion question { get; }
    IQuestionForStudent questionForStudent { get; }
    Itest test { get; }
}
