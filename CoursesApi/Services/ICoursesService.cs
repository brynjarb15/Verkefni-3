﻿using System;
using System.Collections.Generic;
using CoursesApi.Models.DTOModels;
using CoursesApi.Models.ViewModels;

namespace CoursesApi.Services
{
	public interface ICoursesService
	{
		IEnumerable<CoursesListItemDTO> GetCourses(string semester);
		CourseDetailsDTO GetCourseById(int courseId);
		IEnumerable<StudentDTO> GetStudentsByCourseId(int courseId);
		CourseDetailsDTO AddCourse(CourseViewModel newCourse);
		CourseDetailsDTO UpdateCourse(int courseId, CourseViewModel updatedCourse);
		StudentDTO AddStudentToCourse(int courseId, StudentViewModel newStudent);
		bool DeleteCourseById(int courseId);

		IEnumerable<StudentDTO> GetWaitinglistForCourse(int courseId);
		void RemoveStudentFromCourse(int courseId, string ssn);
		StudentDTO AddToWaitinglist(StudentViewModel student, int Id);
	}
}
