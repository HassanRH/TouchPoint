﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace TouchPoint
{
    public class StudentDBsController : ApiController
    {
        private TouchPointDBContext db = new TouchPointDBContext();

        // GET: api/StudentDBs
        public IQueryable<StudentDB> GetStudentDB()
        {
            return db.StudentDB;
        }

        // GET: api/StudentDBs/5
        [ResponseType(typeof(StudentDB))]
        public IHttpActionResult GetStudentDB(int id)
        {
            StudentDB studentDB = db.StudentDB.Find(id);
            if (studentDB == null)
            {
                return NotFound();
            }

            return Ok(studentDB);
        }

        // PUT: api/StudentDBs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudentDB(int id, StudentDB studentDB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != studentDB.Student_ID)
            {
                return BadRequest();
            }

            db.Entry(studentDB).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentDBExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/StudentDBs
        [ResponseType(typeof(StudentDB))]
        public IHttpActionResult PostStudentDB(StudentDB studentDB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StudentDB.Add(studentDB);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (StudentDBExists(studentDB.Student_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = studentDB.Student_ID }, studentDB);
        }

        // DELETE: api/StudentDBs/5
        [ResponseType(typeof(StudentDB))]
        public IHttpActionResult DeleteStudentDB(int id)
        {
            StudentDB studentDB = db.StudentDB.Find(id);
            if (studentDB == null)
            {
                return NotFound();
            }

            db.StudentDB.Remove(studentDB);
            db.SaveChanges();

            return Ok(studentDB);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentDBExists(int id)
        {
            return db.StudentDB.Count(e => e.Student_ID == id) > 0;
        }
    }
}