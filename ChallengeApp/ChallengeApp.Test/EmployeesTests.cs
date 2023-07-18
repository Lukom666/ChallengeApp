namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void employee0Test()
        {
            var employee0 = new Employee("Josh", "Good", "48");
            employee0.AddRating(8);
            employee0.AddRating(5);
            employee0.AddRating(7);
            employee0.AddRating(6);
            employee0.AddRating(7);
            employee0.AddRating(1);

            var result = employee0.Result;

            Assert.AreEqual(34, result);
        }
        [Test]
        public void employee1Test()
        {
            var employee1 = new Employee("Josh", "Good", "48");
            employee1.AddRating(8);
            employee1.AddRating(-5);
            employee1.AddRating(7);
            employee1.AddRating(5);
            employee1.AddRating(4);
            employee1.AddRating(8);

            var result = employee1.Result;

            Assert.AreEqual(27, result);

        }
        [Test]
        public void employee2Test()
        {
            var employee2 = new Employee("Josh", "Good", "48");
            employee2.AddRating(-3);
            employee2.AddRating(3);
            employee2.AddRating(0);
            employee2.AddRating(-1);
            employee2.AddRating(-5);
            employee2.AddRating(-6);

            var result = employee2.Result;

            Assert.AreEqual(-12, result);

        }


    }
}