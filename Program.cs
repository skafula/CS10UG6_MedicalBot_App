using Medical_Bot_App;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isValid = false;
        Patient patient = new Patient();
        Console.WriteLine($"Hello, I'm {MedicalBot.GetBotName()}, I'm here to help you in your medication.");
        Console.WriteLine("Enter your details:");
        
        Console.Write("Enter Patient Name: ");
        do
        {
            isValid = patient.SetName(Console.ReadLine(), out string errorMessage);
            Console.WriteLine(errorMessage);
        } while (!isValid);

        Console.Write("Enter Patient Age: ");
        do
        {
            int patientAge = int.Parse(Console.ReadLine());
            isValid = patient.SetAge(patientAge, out string errorMessage);
            Console.WriteLine(errorMessage);
        } while (!isValid);

        Console.Write("Enter Patient Gender: ");
        do
        {
            isValid = patient.SetGender(Console.ReadLine(), out string errorMessage);
            Console.WriteLine(errorMessage);
        } while (!isValid);

        Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for none: ");
        patient.SetMedicalHistory(Console.ReadLine());

        Console.Clear();
        Console.WriteLine($"Welcome, {patient.GetName()}, {patient.GetAge()}");

        Console.Write("Which of the following symptoms do you have: \nS1. Headache \nS2. Skin rashes \nS3. Dizziness" +
            "\nEnter the symptom code from above list (S1, S2 or S3): ");
        do
        {
            isValid = patient.SetSymptomCode(Console.ReadLine(), out string errorMessage);
            Console.WriteLine(errorMessage);
        } while (!isValid);

        MedicalBot bot = new MedicalBot();
        bot.PrescribeMedication(patient);

        Console.WriteLine("Your prescription based on your age, symptoms and medical history:");
        Console.WriteLine($"{patient.GetPrescription()}");
        Console.WriteLine("\nThank you for coming.");
        
    }
}