// See https://aka.ms/new-console-template for more information
using DalApi1;
using DalTest;
using DO;

class Program
{
    private static readonly IDAl s_dal = new Dal.DalList();

    static void Main(string[] args)
    {
        try
        {
            Initialization.Initialize(s_dal);
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. student");
                Console.WriteLine("2. Questuion");
                Console.WriteLine("3. Answer");
                Console.WriteLine("4. test");
                Console.WriteLine("5. Questuon for student");
                Console.WriteLine("0. exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CrudMenue<student>(s_dal.student, "student", AskStudent);
                        break;
                    case "2":
                        CrudMenue<Question>(s_dal.question, "Question", AskQuestion);

                        break;
                    case "3":
                        CrudMenue<answer>(s_dal.answer, "answer", AskAnswer);
                      
                        break;
                    case "4":
                        CrudMenue<test>(s_dal.test, "test", AskTest);
                      
                        break;
                    case "5":
                        CrudMenue<questionrForStudent>(s_dal.questionForStudent, "answer", AskquestionrForStudent);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");

        }


    }
    private static void CrudMenue<T>(ICRUD <T> crud, string entityName,Func<T> asKFunc) where T : class
    {
        Console.WriteLine("\n\npress create, read, readAll, update or delete\n");
        string ans = Console.ReadLine();
        switch (ans)
        {
            case "create":
                {
                    T obj = asKFunc();
                    crud.Create(obj);
                    Console.WriteLine("created successed\n"); break;
                }
            case "update":
                {
                    T obj = asKFunc();
                    crud.Update(obj);
                    Console.WriteLine("update successed\n"); break;
                }
                case "read":
                {
                    Console.WriteLine($"Enter the ID of the {entityName} to read:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(crud.Read(id));
                    break;
                }
                case "readAll":
                {
                    foreach (var item in crud.ReadAll())
                        Console.WriteLine(item);
                    break;
                }
                case "delete":
                {
                    Console.WriteLine("insert id");
                    int id = int.Parse(Console.ReadLine());
                    crud.Delete(id);
                    Console.WriteLine("delete successed\n");
                    
                }
                break;
            default:
                throw new Exception("\nnot valid input, try again\n");

        }
        
        
    }
    public static student AskStudent()
    {
        Console.WriteLine("insert id");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("insert name");
        string name = Console.ReadLine();
        Console.WriteLine("insert test id");
        int test_id = int.Parse(Console.ReadLine());
        Console.WriteLine("insert mark");
        int mark = int.Parse(Console.ReadLine());
        student student = new student(id, name, test_id, mark);
        return student;
    }
    public static answer AskAnswer()
    {
        Console.WriteLine("insert question id");
        int question_id = int.Parse(Console.ReadLine());
        Console.WriteLine("insert content");
        string content = Console.ReadLine();

        answer ans = new answer(0, question_id, content);
        return ans;
    }
    public static Question AskQuestion()
    {
        Console.WriteLine("insert question id");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("insert sbject for qestion");
        Console.WriteLine("1-worldHistory");
        Console.WriteLine("2-worldGeography");
        Console.WriteLine("3-worldMath");
        Console.WriteLine("4-grammarInEnglish");
        int sbj = int.Parse(Console.ReadLine());
        Console.WriteLine("insert contentQues");
        string contentQues =Console.ReadLine();
        Console.WriteLine("insert correctAnsId");
        int correctAnsId = int.Parse(Console.ReadLine());
        Question q = new Question(id, sbj, contentQues, correctAnsId);
        return q;

    }
    public static test AskTest()
    {
        Console.WriteLine("insert test id");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("insert subject");

        Console.WriteLine("1-history");
        Console.WriteLine("2-math");
        Console.WriteLine("3-english");
        Console.WriteLine("4-geography");
        int sbj = int.Parse(Console.ReadLine());
        Console.WriteLine("insert sumQuestions");
        int sumQuestions = int.Parse(Console.ReadLine());
        DateTime date = DateTime.Parse(Console.ReadLine());
        test t = new test(id, sbj,date, sumQuestions);
        return t;
    }
    public static questionrForStudent AskquestionrForStudent()
    {
        Console.WriteLine("insert studentId");
        int studentId = int.Parse(Console.ReadLine());
        Console.WriteLine("insert testID");
        int testID = int.Parse(Console.ReadLine());
        Console.WriteLine("insert answerId");
        int answerId = int.Parse(Console.ReadLine());
        Console.WriteLine("INSERT questionSelectedID");
        int questionSelectedID = int.Parse(Console.ReadLine());
        questionrForStudent qs = new questionrForStudent(studentId, testID, answerId, questionSelectedID);
        return qs;



    } 

}