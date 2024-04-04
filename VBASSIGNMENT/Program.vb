Imports System


Class Animal
    Public Property Name As String
    Public Property Species As String


    Public Sub New(animalName As String, animalSpecies As String)
        Name = animalName
        Species = animalSpecies
    End Sub


    Public Sub DisplayInfo()
        Console.WriteLine($"Name: {Name}, Species: {Species}")
    End Sub
End Class

Module Program
    Sub Main()
        Dim animals As New List(Of Animal)()

        While True
            Console.WriteLine("Animal Information System")
            Console.WriteLine("1. Add Animal")
            Console.WriteLine("2. Display All Animals")
            Console.WriteLine("3. Exit")
            Console.Write("Enter your choice: ")

            Dim choice As Integer = Integer.Parse(Console.ReadLine())

            Select Case choice
                Case 1
                    Console.Write("Enter animal name: ")
                    Dim name As String = Console.ReadLine()
                    Console.Write("Enter animal species: ")
                    Dim species As String = Console.ReadLine()

                    Dim newAnimal As New Animal(name, species)
                    animals.Add(newAnimal)
                    Console.WriteLine("Animal added successfully!")
                Case 2
                    Console.WriteLine("All Animals:")
                    For Each animal In animals
                        animal.DisplayInfo()
                    Next
                Case 3
                    Console.WriteLine("Exiting the program. Goodbye!")
                    Exit Sub
                Case Else
                    Console.WriteLine("Invalid choice. Please select a valid option.")
            End Select
        End While
    End Sub
End Module