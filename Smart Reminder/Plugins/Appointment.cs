using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Phone.Tasks;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;



public class Appointment : BaseCommand
{
    public void add(string options)
    {
        try
        {
            SaveAppointmentTask saveAppointmentTask = new SaveAppointmentTask();

            saveAppointmentTask.StartTime = DateTime.Now.AddHours(2);
            saveAppointmentTask.EndTime = DateTime.Now.AddHours(3);
            saveAppointmentTask.Subject = "Appointment subject";
            saveAppointmentTask.Location = "Appointment location";
            saveAppointmentTask.Details = "Appointment details";
            saveAppointmentTask.IsAllDayEvent = false;
            saveAppointmentTask.Reminder = Reminder.FifteenMinutes;
            saveAppointmentTask.AppointmentStatus = Microsoft.Phone.UserData.AppointmentStatus.Busy;

            saveAppointmentTask.Show();
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }
        
    }
}

