
using DO;
using DalApi1;

namespace Dal;

internal class questionForTestImplementation : IQuestionForStudent
{
     public int Create(questionrForStudent q){
       int id= DataSource.config.NextquesforTestId;
         questionrForStudent newQ = new questionrForStudent
          {
             studentId = q.studentId,
                testID = q.testID,
                answerId = q.answerId,
                questionSelectedID = id
          };
          DataSource.questionrForTests.Add(newQ);
          return id;
    }

    public void Delete(int id)
    {
        foreach (questionrForStudent q in DataSource.questionrForTests)
        {
            if (q.questionSelectedID == id)
            {
                DataSource.questionrForTests.Remove(q);
                return;
            }
            
        }
        
        {
            throw new DO.IdNotExistsExeption("Question for student with id " + id + " not found.");
        }
    }

    public questionrForStudent? Read(int id)
    {
        foreach (questionrForStudent q in DataSource.questionrForTests)
        {
            if (q.questionSelectedID == id)
            {
                return q;
            }
        }
        throw new DO.IdNotExistsExeption("Question for student with id " + id + " not found.");
        return null;
    }

    public List<questionrForStudent> ReadAll()
    {
        List<questionrForStudent> newlist = new List<questionrForStudent>(DataSource.questionrForTests);
        return newlist;
    }

    public void Update(questionrForStudent item)
    {
        int index = DataSource.questionrForTests.FindIndex(s => s != null && s.questionSelectedID == item.questionSelectedID);

        if (index != -1)
        {
            // מחליפים את ה-record הישן בחדש שהתקבל
            DataSource.questionrForTests[index] = item;
        }
        else
        {
            throw new DO.IdNotExistsExeption("Question for student with id " + item.questionSelectedID + " not found.");
        }

    }
}
