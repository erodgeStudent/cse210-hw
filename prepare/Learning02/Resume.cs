public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

        public void Display()
    {
        Console.WriteLine($"\nName: {_name}");
        Console.WriteLine($"Experience:");

        //write a loop for each job
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}