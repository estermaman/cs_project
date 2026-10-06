using DO;
using DalApi1;

namespace Dal
{
    internal class questionImplementation : Iquestion
    {
        public int Create(Question item)
        {
            int id = DataSource.config.NextquestionId;
            Question newQ = new Question
            {
                id = id,
                Sub = item.Sub,
                contentQues = item.contentQues,
                correctAnsId = item.correctAnsId
            };
            DataSource.Questions.Add(newQ);
            return id;
        }

        public void Delete(int id)
        {
            foreach (Question question in DataSource.Questions)
            {
                if (question.id == id)
                {
                    DataSource.Questions.Remove(question);
                    return;
                }
                
                
            }
            
                    throw new DO.IdNotExistsExeption("Question with id " + id + " not found.");
            
        }

        public Question? Read(int id)
        {
            foreach (Question item in DataSource.Questions)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            throw new DO.IdNotExistsExeption("Question with id " + id + " not found.");
            return null;

        }

        public List<Question> ReadAll()
        {
            List<Question> newlist = new List<Question>(DataSource.Questions);
            return newlist;
        }

       
        public void Update(Question item)
        {
            int index = DataSource.Questions.FindIndex(s => s != null && s.id == item.id);

            if (index != -1)
            {
                // מחליפים את ה-record הישן בחדש שהתקבל
                DataSource.Questions[index] = item;
            }
            else
            {
                throw new DO.IdNotExistsExeption("Question with id " + item.id + " not found.");
            }

        }
    }
}
