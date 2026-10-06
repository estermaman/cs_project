
using DO;
using DalApi1;

namespace DalTest;

public static class Initialization
{
    private static IDAl s_dal;
    private static void createStudent()
    {
        student s1 = new student()
        {
            identty = 123,
            name = "ester",
            numTest = 1,
            grade = 95
        };
        student s2 = new student()
        {
            identty = 456,
            name = "mimi",
            numTest = 1,
            grade = 100
        };
        student s3 = new student()
        {
            identty = 102,
            name = "ruth",
            numTest = 2,
            grade = 82
        };
        student s4 = new student() 
            {
            identty = 789,
            name = "yael",
            numTest = 1,
            grade = 90
        };
        student s5 = new student()
            {
            identty = 111,
            name = "shira",
            numTest = 3,
            grade = 75
        };
        s_dal.student.Create(s1);   
        s_dal.student.Create(s2);
        s_dal.student.Create(s3);
        s_dal.student.Create(s4);
        s_dal.student.Create(s5);
    }
    private static void createTest()
    {
        test t1 = new test()
        {
            id = 150,
            subj =SubjTestEnum.history,
            date = DateTime.Now,
            sumQuestions = 50
        };
        test t2 = new test()
        {
            id = 151,
            subj = SubjTestEnum.english,
            date = DateTime.Now,
            sumQuestions = 30
        };
        test t3 = new test()
        {
            id = 152,
            subj = SubjTestEnum.math,
            date = DateTime.Now,
            sumQuestions = 40
        };
        s_dal.test.Create(t1);
        s_dal.test.Create(t2);
        s_dal.test.Create(t3);
    }
    private static void createQuestion()
    {
        Question q1 = new Question()
        {
            id = 1,
            Sub = SubjQuestionEnum.capitalCities,
            contentQues = "What is the capital of France?",
            correctAnsId = 1
        };
        Question q2 = new Question()
        {
            id = 2,
            Sub = SubjQuestionEnum.algebra,
            contentQues = "Solve for x: 2x + 5 = 15",
            correctAnsId = 4
        };
        Question q3 = new Question()
        {
            id = 3,
            Sub = SubjQuestionEnum.woldWar2,
            contentQues = "Who was the leader of Nazi Germany during World War II?",
            correctAnsId = 7
        };
        Question q4 = new Question()
        {
            id = 4,
            Sub = SubjQuestionEnum.grammar,
            contentQues = "Identify the subject in the following sentence: 'The cat sat on the mat.'",
            correctAnsId = 10
        };
        Question q5 = new Question()
        {
            id = 5,
            Sub = SubjQuestionEnum.capitalCities,
            contentQues = "What is the capital of Japan?",
            correctAnsId = 13
        };
        //Question q6 = new Question()
        //{
        //    id = 6,
        //    Sub = SubjQuestionEnum.algebra,
        //    contentQues = "Simplify the expression: 3x + 2x - 5",
        //    correctAnsId = 6
        //};
        //Question q7 = new Question()
        //{
        //    id = 7,
        //    Sub = SubjQuestionEnum.woldWar2,
        //    contentQues = "In which year did World War II end?",
        //    correctAnsId = 7
        //};
        //Question q8 = new Question()
        //{
        //    id = 8,
        //    Sub = SubjQuestionEnum.grammar,
        //    contentQues = "Identify the verb in the following sentence: 'She runs every morning.'",
        //    correctAnsId = 8
        //};
        //Question q9 = new Question()
        //{
        //    id = 9,
        //    Sub = SubjQuestionEnum.capitalCities,
        //    contentQues = "What is the capital of Australia?",
        //    correctAnsId = 9
        //};
        //Question q10 = new Question()
        //{
        //    id = 10,
        //    Sub = SubjQuestionEnum.algebra,
        //    contentQues = "Solve for y: 3y - 7 = 11",
        //    correctAnsId = 10
        //};
        //Question q11 = new Question()
        //    {
        //    id = 11,
        //    Sub = SubjQuestionEnum.woldWar2,
        //    contentQues = "Which countries were part of the Axis Powers during World War II?",
        //    correctAnsId = 11
        //};
        //Question q12 = new Question()
        //{
        //    id = 12,
        //    Sub = SubjQuestionEnum.grammar,
        //    contentQues = "Identify the adjective in the following sentence: 'The tall building is impressive.'",
        //    correctAnsId = 12
        //};

        //Question q13 = new Question()
        //    {
        //    id = 13,
        //    Sub = SubjQuestionEnum.capitalCities,
        //    contentQues = "What is the capital of Canada?",
        //    correctAnsId = 13
        //};

        s_dal.question.Create(q1);
        s_dal.question.Create(q2);
        s_dal.question.Create(q3);
        s_dal.question.Create(q4);
        s_dal.question.Create(q5);
        //s_dal.question.Create(q6);
        //s_dal.question.Create(q7);
        //s_dal.question.Create(q8);
        //s_dal.question.Create(q9);
        //s_dal.question.Create(q10);
        //s_dal.question.Create(q11);
        //s_dal.question.Create(q12);
        //s_dal.question.Create(q13);

    }
    private static void createAnswer()
    {
        answer a1 = new answer()
        {
            idAnswer = 1,
            QuestionId=1,
            Text = "Paris"
        };
        answer a6 = new answer()
        {
            idAnswer =2,
            QuestionId = 1,
            Text = "n-york"
        };
        answer a7 = new answer()
        {
            idAnswer = 3,
            QuestionId = 1,
            Text = "vishi"
        };

        answer a2 = new answer()
        {
            idAnswer = 4,
            QuestionId=2,
            Text = "5"
        };
        answer a8 = new answer()
        {
            idAnswer = 5,
            QuestionId = 2,
            Text = "3"
        };

        answer a9 = new answer()
            {
            idAnswer = 6,
            QuestionId = 2,
            Text = "2"
        };

        answer a3 = new answer()
        {
            idAnswer =7,
            QuestionId=3,
            Text = "Adolf Hitler"
        };
        answer a10 = new answer()
            {
            idAnswer = 8,
            QuestionId=3,
            Text = "Winston Churchill"
        };
        answer a11 = new answer()
        {
            idAnswer = 9,
            QuestionId=3,
            Text = "Joseph Stalin"
        };
        answer a4 = new answer()
        {
            idAnswer = 10,
            QuestionId=4,
            Text = "cat"
        };
        answer a12 = new answer()
            {
            idAnswer = 11,
            QuestionId=4,
            Text = "mat"
        };
        answer a13 = new answer()
            {
            idAnswer =12,
            QuestionId=4,
            Text = "sat"
        };
        answer a5 = new answer()
        {
            idAnswer = 13,
            QuestionId=5,
            Text = "Tokyo"
        };
        answer a14 = new answer()
            {
            idAnswer = 14,
            QuestionId=5,
            Text = "Kyoto"
        };
        answer a15 = new answer()
            {
            idAnswer = 15,
            QuestionId=5,
            Text = "Osaka"
        };
        s_dal.answer.Create(a1);
        s_dal.answer.Create(a2);
        s_dal.answer.Create(a3);
        s_dal.answer.Create(a4);
        s_dal.answer.Create(a5);
        s_dal.answer.Create(a6);
        s_dal.answer.Create(a7);
        s_dal.answer.Create(a8);
        s_dal.answer.Create(a9);
        s_dal.answer.Create(a10);
        s_dal.answer.Create(a11);
        s_dal.answer.Create(a12);
        s_dal.answer.Create(a13);
        s_dal.answer.Create(a14);
        s_dal.answer.Create(a15);

    }

    private static void createQuestionForStudent()
    {
        questionrForStudent q1= new questionrForStudent()
        {
            studentId = 123,
            testID = 1,
            answerId = 12,
            questionSelectedID = 1
        };
        s_dal.questionForStudent.Create(q1);
    }

    public static void Initialize(IDAl dal)
    {
        s_dal = dal;
        createStudent();
        createQuestion();
        createAnswer();
        createTest();
        createQuestionForStudent();
    }
}