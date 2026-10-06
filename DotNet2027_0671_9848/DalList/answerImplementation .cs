using DalApi1;
using DO;
using System.Collections.Generic;


namespace Dal;

internal class answerImplementation : Ianswer
{
    public int Create(answer item)  
    {

        int id = DataSource.config.NextanswerId;
       answer a = new answer
        {
            idAnswer = id,
            QuestionId = item.QuestionId,
            Text=item.Text,
        };
        DataSource.Answers.Add(a);
        return id;
    }
    public answer? Read(int id)
    {
        foreach(answer answer in DataSource.Answers) {
            if (answer.idAnswer == id)
            {
                return answer;
            }
        }
        throw new DO.IdNotExistsExeption("Answer with id " + id + " not found.");
        return null;
    }
    public List<answer> ReadAll()
    {
        List < answer > newanswers = new List<answer>(DataSource.Answers);
        return newanswers;
    }
    public void Update(answer item)
    {
        int index = DataSource.Answers.FindIndex(s => s != null && s.idAnswer == item.idAnswer);

        if (index != -1)
        {
            // מחליפים את ה-record הישן בחדש שהתקבל
            DataSource.Answers[index] = item;
        }
        else
        {
            throw new DO.IdNotExistsExeption("Answer with id " + item.idAnswer + " not found.");
        }

    }
    
   public  void Delete(int id)
    {
        foreach (answer answer in DataSource.Answers)
        {
            if (answer.idAnswer == id)
            {
                DataSource.Answers.Remove(answer);
                return;
            }
        }
        throw new DO.IdNotExistsExeption("Answer with id " + id + " not found.");
    }

}
