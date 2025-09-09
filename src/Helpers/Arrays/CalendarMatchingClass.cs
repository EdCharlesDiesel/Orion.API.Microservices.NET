namespace Orion.Helpers.Arrays
{
    public class CalendarMatchingClass
    {
        // O(c1 + c2) time | O(c1 + c2) space - where c1 and c2 are the respective numbers of meetings in Calendar1 and Calendar2
        public static List<StringMeeting> CalendarMatching(
            List<StringMeeting> calendar1,
            StringMeeting dailyBounds1,
            List<StringMeeting> calendar2,
            StringMeeting dailyBounds2,
            int meetingDuration
        )
        {
            List<Meeting> updatedCalendar1 = UpdateCalendar(calendar1, dailyBounds1);
            List<Meeting> updatedCalendar2 = UpdateCalendar(calendar2, dailyBounds2);

            List<Meeting> mergedCalendar = MergeCalendars(updatedCalendar1, updatedCalendar2);
            List<Meeting> flattenedCalendar = FlattenCalendar(mergedCalendar);

            return GetMatchingAvailabilities(flattenedCalendar, meetingDuration);
        }

        public static List<Meeting> UpdateCalendar(List<StringMeeting> calendar, StringMeeting dailyBounds)
        {
            List<StringMeeting> updatedCalendar = new List<StringMeeting>();
            updatedCalendar.Add(new StringMeeting("0:00", dailyBounds.Start));
            updatedCalendar.AddRange(calendar);
            updatedCalendar.Add(new StringMeeting(dailyBounds.End, "23:59"));

            List<Meeting> calendarInMinutes = new List<Meeting>();
            foreach (var entry in updatedCalendar)
            {
                calendarInMinutes.Add(new Meeting(
                    TimeToMinutes(entry.Start),
                    TimeToMinutes(entry.End)
                ));
            }
            return calendarInMinutes;
        }

        public static List<Meeting> MergeCalendars(List<Meeting> calendar1, List<Meeting> calendar2)
        {
            List<Meeting> merged = new List<Meeting>();
            int i = 0, j = 0;

            while (i < calendar1.Count && j < calendar2.Count)
            {
                if (calendar1[i].Start < calendar2[j].Start)
                {
                    merged.Add(calendar1[i++]);
                }
                else
                {
                    merged.Add(calendar2[j++]);
                }
            }

            while (i < calendar1.Count) merged.Add(calendar1[i++]);
            while (j < calendar2.Count) merged.Add(calendar2[j++]);

            return merged;
        }

        public static List<Meeting> FlattenCalendar(List<Meeting> calendar)
        {
            List<Meeting> flattened = new List<Meeting>();
            flattened.Add(calendar[0]);

            for (int i = 1; i < calendar.Count; i++)
            {
                Meeting current = calendar[i];
                Meeting previous = flattened[flattened.Count - 1];

                if (previous.End >= current.Start)
                {
                    flattened[flattened.Count - 1] = new Meeting(
                        previous.Start,
                        Math.Max(previous.End, current.End)
                    );
                }
                else
                {
                    flattened.Add(current);
                }
            }
            return flattened;
        }

        public static List<StringMeeting> GetMatchingAvailabilities(List<Meeting> calendar, int meetingDuration)
        {
            List<StringMeeting> available = new List<StringMeeting>();

            for (int i = 1; i < calendar.Count; i++)
            {
                int start = calendar[i - 1].End;
                int end = calendar[i].Start;

                if (end - start >= meetingDuration)
                {
                    available.Add(new StringMeeting(
                        MinutesToTime(start),
                        MinutesToTime(end)
                    ));
                }
            }

            return available;
        }

        public static int TimeToMinutes(string time)
        {
            var parts = time.Split(':');
            int hours = int.Parse(parts[0]);
            int minutes = int.Parse(parts[1]);
            return hours * 60 + minutes;
        }

        public static string MinutesToTime(int minutes)
        {
            int hours = minutes / 60;
            int mins = minutes % 60;
            return $"{hours:D2}:{mins:D2}";
        }
    }

    // Meeting in raw strings ("09:00", "17:30")
    public class StringMeeting
    {
        public string Start { get; set; }
        public string End { get; set; }

        public StringMeeting(string start, string end)
        {
            Start = start;
            End = end;
        }
    }
    
}
