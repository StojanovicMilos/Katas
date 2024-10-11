// https://leetcode.com/problems/the-number-of-the-smallest-unoccupied-chair/description/
Console.WriteLine("Hello, World!");

public class Solution
{
    public int SmallestChair(int[][] times, int targetFriend)
    {
        var chairs = new List<Chair>(times.Length);
        var friends = times.Select((time, index) => new Friend(index, new TimeFrame(time[0], time[1]))).OrderBy(f => f.TimeFrame.Start).ToList();
        foreach (var friend in friends)
        {
            var chair = chairs.FirstOrDefault(c => c.IsFreeAt(friend.TimeFrame.Start));
            if (chair == null)
            {
                chair = new Chair();
                chairs.Add(chair);
            }

            chair.SitAt(friend.TimeFrame);
            if (friend.Index == targetFriend)
            {
                return chairs.IndexOf(chair);
            }
        }

        return 0;
    }
}

public class Chair
{
    private TimeFrame _busy;

    public bool IsFreeAt(int start) => _busy.IsFreeAt(start);

    public void SitAt(TimeFrame timeFrame) => _busy = timeFrame;
}

public class Friend
{
    public int Index { get; }
    public TimeFrame TimeFrame { get; }

    public Friend(int index, TimeFrame timeFrame)
    {
        Index = index;
        TimeFrame = timeFrame;
    }
}

public class TimeFrame
{
    private readonly int _start;
    private readonly int _end;

    public TimeFrame(int start, int end)
    {
        _start = start;
        _end = end;
    }

    public bool IsFreeAt(int time) => time >= _end;

    public int Start => _start;
}