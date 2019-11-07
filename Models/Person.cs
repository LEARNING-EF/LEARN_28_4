namespace Models
{
	public class Person : BaseEntity
	{
		public Person() : base()
		{
		}

		// **********
		public int Age { get; set; }
		// **********

		// **********
		public string FullName { get; set; }
		// **********

		// **********
		//public string SomeProperty { get; set; }
		/// <summary>
		/// Rename!
		/// </summary>
		public string SomeNewProperty { get; set; }
		// **********
	}
}
