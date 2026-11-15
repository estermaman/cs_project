using DalApi1;
using DO;
using System.Collections.Generic;
using System.Reflection;
using Tools;

namespace Dal;

internal class answerImplementation : Ianswer
{
    public int Create(answer item)  
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Start creating answer for question {item.QuestionId}");
        int id = DataSource.config.NextanswerId;
       answer a = new answer
        {
            idAnswer = id,
            QuestionId = item.QuestionId,
            Text=item.Text,
        };
        DataSource.Answers.Add(a);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully created answer with id {id}");
        return id;
    }
    public answer? Read(int id)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Start reading answer with id {id}");
        foreach (answer answer in DataSource.Answers) {
            if (answer.idAnswer == id)
            {
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully read answer with id {id}");
                return answer;
            }
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: Answer with id {id} not found.");
        throw new DO.IdNotExistsExeption("Answer with id " + id + " not found.");
    }
    public List<answer> ReadAll()
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start reading all answers");
        List < answer > newanswers = new List<answer>(DataSource.Answers);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully retrieved {newanswers.Count} answers");
        return newanswers;
    }
    public void Update(answer item)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Start updating answer with id {item.idAnswer}");
        int index = DataSource.Answers.FindIndex(s => s != null && s.idAnswer == item.idAnswer);

        if (index != -1)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully updated answer with id {item.idAnswer}"); DataSource.Answers[index] = item;
        }
        else
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: Answer with id {item.idAnswer} not found for update.");
            throw new DO.IdNotExistsExeption("Answer with id " + item.idAnswer + " not found.");
        }

    }
    
   public  void Delete(int id)
    {
        foreach (answer answer in DataSource.Answers)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Start deleting answer with id {id}");
            if (answer.idAnswer == id)
            {
                DataSource.Answers.Remove(answer);
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully deleted answer with id {id}");
                return;
            }
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: Answer with id {id} not found for deletion.");
        throw new DO.IdNotExistsExeption("Answer with id " + id + " not found.");
    }

}
