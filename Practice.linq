<Query Kind="Program">
  <Connection>
    <ID>a9fcb0ff-2ed4-4185-9acc-142d6745099a</ID>
    <Persist>true</Persist>
    <Server>(localdb)\v11.0</Server>
    <AttachFile>true</AttachFile>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
  </Connection>
</Query>

void Main()
{
	
	var f = Customers;
	f.Where(n => n.Name.StartsWith("T")).Dump();
	
	int[] num = {1,2,3,4,5,6,7,8,9};
	
	num.Dump();
	
	string[] names = {"john","james", "jane"};
	
	names.Dump();
	
	long[] money = {1,43,5,43,};
	
	//changes
}

// Define other methods and classes here