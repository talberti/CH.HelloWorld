using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using API.Data;


namespace API.UnitTest
{
    [TestClass]
    public class MessageProviderUnitTests
    {
        [TestMethod]
        public void MessageProvider_Message_ShouldReturn_Hello_World()
        {
            // Arrange
            string expectedvalue = "Hello World";
            var messageProvider = new MessageProvider();

            // Act
            string message = messageProvider.Message;
            
            // Assert
            Assert.AreEqual(message, expectedvalue);
        }

    }
}
