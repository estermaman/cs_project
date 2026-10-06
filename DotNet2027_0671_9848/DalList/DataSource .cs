
using DO;

namespace Dal
{
    internal static class DataSource
    {
        internal static List<answer?> Answers = new List<answer?>();
        internal static List<student?> Students = new List<student?>();   
        internal static List<Question?> Questions = new List<Question?>();
        internal static List<test?> Tests = new List<test?>();    
        internal static List<questionrForStudent?> questionrForTests = new List<questionrForStudent?>();
        internal static class config
        {
            internal static int answerId = 1000;
            private static int nextanswerId = answerId;
            internal static int NextanswerId {  get { return nextanswerId++; } }

            internal static int questionId = 1000;
            private static int nextquestionId = questionId;
            internal static int NextquestionId { get { return nextquestionId++; } }


            internal static int quesForTestId = 1000;
            private static int nextquesforTestId = quesForTestId;
            internal static int NextquesforTestId { get { return nextquesforTestId++; } }

            internal static int testId = 1000;
            private static int nexttestId = testId;
            internal static int NexttestId { get { return nexttestId++; } }

        }
    }
}
