using System.Globalization;
using Orion.API.HumanResources.Business.EventArguments;
using Orion.DataAccess.Postgres.Entities;

namespace Orion.API.HumanResources.Business
{
    public interface IEmployeeService
    {
        event EventHandler<EmployeeIsAbsentEventArgs>? EmployeeIsAbsent;
        Task AddCalendarAsync(OrionCalendarEvent calendar);
        Task AttendCourseAsync(Employee employee, Course attendedCourse);
        ExternalEmployee CreateExternalEmployee(string firstName, string lastName, string company);
        Task<OrionCalendarEvent> CreateCalendarAsync(string firstName, string lastName, string company,string employeeID);
        OrionCalendarEvent? FetchCalendar(int employeeId);
        Task<OrionCalendarEvent?> FetchCalendarAsync(Guid employeeId);
        Task<IEnumerable<OrionCalendarEvent>> FetchCalendarsAsync();
        Task GiveMinimumRaiseAsync(Employee employee);
        Task GiveRaiseAsync(Employee employee, int raise);
        void NotifyOfAbsence(Employee employee);
    }


}