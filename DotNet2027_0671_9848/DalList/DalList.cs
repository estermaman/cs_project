using DalApi1;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalList: IDAl
    {
        public Istudent student => new studentImplementation();
        public Itest test => new TestImplementation();
        public Iquestion question => new questionImplementation();
        public Ianswer answer => new answerImplementation();
        public IQuestionForStudent questionForStudent => new questionForTestImplementation();

    }
}
