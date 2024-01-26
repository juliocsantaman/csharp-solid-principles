using SingleResponsability;

StudentRepository studentRepository = new StudentRepository();

ExportHelper exportHelper = new ExportHelper();
exportHelper.ExportStudents(studentRepository.GetAll());

Console.WriteLine("Proceso Completado");