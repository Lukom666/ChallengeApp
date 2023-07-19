
namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void CheckingIfNumbersAreEqual()
        {
            int number1 = 1;
            int number2 = 1;

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void CheckingIfFloatingNumbersAreNotEqual()
        {
            float number3 = 7.35F;
            float number4 = 7.43F;

            Assert.AreNotEqual(number3, number4);
        }
        [Test]
        public void CheckingifStringNameAreEqual()
        {
            string name0 = ("Lukas");
            string name1 = ("Lukas");

            Assert.AreEqual(name0, name1);
        }
        [Test]
        public void CheckingIfEmployeesAreDifferentUser()
        {
            var employee0 = GetEmployee("Lukas");
            var employee1 = GetEmployee("Lukas");

            Assert.AreNotEqual(employee0, employee1);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name, name, name);
        }
    }
}
