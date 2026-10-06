using DalApi1;
using DO;


namespace Dal
{
    internal class studentImplementation : Istudent
    {
        public int Create(student item)
        {
           foreach (student s in DataSource.Students)
            {
                if (s.identty == item.identty)
                {
                    throw new DO.IdAlreadyExistsExeotion("Student with id " + item.identty + " already exists.");
                }
            }
            student newStudent = new student
            {
                identty = item.identty,
                name = item.name,
                numTest = item.numTest,
                grade = item.grade
            };
            DataSource.Students.Add(newStudent);
            return item.identty;
        }

        public void Delete(int id)
        {
            foreach (student student in DataSource.Students)
            {
                if (student.identty == id)
                {
                    DataSource.Students.Remove(student);
                    return;
                }
             
            }
               
            
                throw new DO.IdNotExistsExeption("Student with id " + id + " not found.");
            
        }
        public student? Read(int id)
        {
            foreach (student s in DataSource.Students)
            {
                if (s.identty == id)
                {
                    return s;
                }
                
            }

            throw new DO.IdNotExistsExeption("Student with id " + id + " not found.");
                return null;
        }

        public List<student> ReadAll()
        {
            Console.WriteLine("in readAll");
            List<student> newlist = new List<student>(DataSource.Students);
            return newlist;
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
                throw new DO.IdNotExistsExeption("Student with id " + item.identty + " not found.");
            }

        }
    }
}
