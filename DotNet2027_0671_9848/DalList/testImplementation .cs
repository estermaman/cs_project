using DO;
using DalApi1;

namespace Dal
{
    internal class TestImplementation : Itest
    {
        public int Create(test item)
        {
            int id = DataSource.config.NexttestId;
            test t = new test
            {
                id = id,
                subj = item.subj,
                date = item.date,
                sumQuestions = item.sumQuestions
            };
            DataSource.Tests.Add(t);
            return id;
        }
        public void Update(student item)
        {
            int index = DataSource.Students.FindIndex(s => s != null && s.identty == item.identty);

            if (index != -1)
            {
                // מחליפים את ה-record הישן בחדש שהתקבל
                DataSource.Students[index] = item;
            }
            else
            {
                Console.WriteLine("Student with id " + item.identty + " not found.");
            }

        }
        public void Update(test item)
        {
            int index = DataSource.Tests.FindIndex(s => s != null && s.id == item.id);

            if (index != -1)
            {
                // מחליפים את ה-record הישן בחדש שהתקבל
                DataSource.Tests[index] = item;
            }
            else
            {
                throw new DO.IdNotExistsExeption("Student with id " + item.id + " not found.");
            }

        }
        public void Delete(int id)
        {
            foreach (test t in DataSource.Tests)
            {
                if (t.id == id)
                {
                    DataSource.Tests.Remove(t);
                    return;
                }
                
                
            }
            throw new DO.IdNotExistsExeption("Test with id " + id + " not found.");

        }
        public test? Read(int id)
        {
            foreach (test t in DataSource.Tests)
            {
                if (t.id == id)
                {
                    return t;
                }
            }
            throw new DO.IdNotExistsExeption("Test with id " + id + " not found.");
            return null;
        }

        public List<test> ReadAll()
        {
            List<test> newlist = new List<test>(DataSource.Tests);
            return newlist;
        }




    }
}