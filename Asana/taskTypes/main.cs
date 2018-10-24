public static class main()
{
    /// <assignment>
    /// You have some tasks in your Asana account. For each ith of them you know its deadlines(i), which is the last
    /// day  by which it should be completed. As you can see in your calendar, today's date is day. Asana labels each
    /// task in accordance with its due date:
    /// If the task is due today or it's already overdue, it is labeled as Today;
    /// If the task is due within a week but not today - that is, its deadline is somewhere between day + 1 and day
    /// + 7 both inclusive - it is labeled as Upcoming;
    /// All other tasks are labeled as Later;
    /// Given an array of deadlines and today's date day, your goal is to find the number of tasks with each label
    /// type and return it as an array with the format [Today, Upcoming, Later], where Today, Upcoming and Later are
    /// the number of tasks that correspond to that label.
    /// </assignment>
    /// <param name="deadlines"></param>
    /// <param name="day"></param>
    /// <returns></returns>
    public static int[] TasksTypes(int[] deadlines, int day)
    {
      int today = 0;
      int upcoming = 0;
      int later = 0;

      foreach (int t in deadlines)
      {
        if (t <= day)
          today++;

        else if (t >= day + 1 && t <= day + 7)
          upcoming++;

        else
        {
          later++;
        }
      }

      return new[] {today, upcoming, later};
    }
}
