using System;

public class Userprofile
{
	public Userprofile()
	{
	public Guid id { get; set; };
    public Guid name { get; set; };
    public Guid email { get; set; };
    public Guid password { get; set; };
    public Guid adddress { get; set; };
    public Guid phone { get; set; };	
	}
static void Main(string[] args)
{
    Userprofile userprofile = new Userprofile();
}
}
