using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using School.EF.Data;
using School.Models;
using School.Repositories;
using School.Repositories.RepoFactory;
using School.Repositories.UnitOfWork;
using School.Services.Bridges;
using School.Services.Models;

namespace School.Services.Controllers
{
    public class StudentsController : ApiController
    {

        private UnitOfWorkScope unitOfWork = null;

        public StudentsController()
        {
            //this.unitOfWork = new UnitOfWorkScope(false);
        }

        public HttpResponseMessage GetAll()
        {
            ICollection<Student> all = null;
            ICollection<StudentModel> models = null;
            using (this.unitOfWork = new UnitOfWorkScope(true))
            {
                all = UnitOfWorkScope.StudentRepository.GetAll().ToList();
            }

            models = new HashSet<StudentModel>();

            foreach (var student in all)
            {
                models.Add(ModelsBridge.SerilizeStudentModel(student));
            }

            return this.Request.CreateResponse(HttpStatusCode.OK, models);

        }

        public HttpResponseMessage Post(StudentModel studentModel)
        {
            Student student = ModelsBridge.SerilizeStudent(studentModel);
            using (this.unitOfWork = new UnitOfWorkScope(true))
            {

                UnitOfWorkScope.StudentRepository.Add(student);
            }

            return this.Request.CreateResponse(HttpStatusCode.OK, student);
        }
    }
}
