using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using School.Models;
using School.Services.Models;

namespace School.Services.Bridges
{
    public static class ModelsBridge
    {
        public static Student SerilizeStudent(StudentModel model)
        {
            Student student = new Student();
            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            student.Age = model.Age;
            student.Grade = model.Grade;

            return student;
        }

        public static StudentModel SerilizeStudentModel(Student student)
        {
            StudentModel studentModel = new StudentModel();
            studentModel.FirstName = student.FirstName;
            studentModel.LastName = student.LastName;
            studentModel.Age = student.Age;
            studentModel.Grade = student.Grade;

            return studentModel;
        }
    }
}