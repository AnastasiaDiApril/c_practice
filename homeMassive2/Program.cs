double[] line1 = new double[] {
    ReadDouble("Введите k1"),
    ReadDouble("Введите b1")
    };
double[] line2 = new double[] {
    ReadDouble("Введите k2"),
    ReadDouble("Введите b2")
    };

if (hasCrossPoint(line1, line2)) {
    double[] crossPoint = FindCrossPoint(line1, line2);
    Console.WriteLine($"({crossPoint[0]}, {crossPoint[1]})");
}

bool hasCrossPoint(double[] line1, double[] line2) {
    if (line1[0] == line2[0]) {
        if (line1[1] == line2[1]) {
            Console.WriteLine("Прямые совпадают и имеют бесконечное количество решений");
        } else {
             Console.WriteLine("Прямые параллельны другу друг и не имеют точек пересечения");
        }
        return false;
    }
    return true;
}

double[] FindCrossPoint(double[] line1, double[] line2 ) {
    double x = (line2[1] - line1[1])/(line1[0] - line2[0]);
    double y = line1[0] * x + line1[1];
    return new[] {x, y};
}

double ReadDouble(string prompt) {
    Console.WriteLine(prompt);
    return Convert.ToDouble(Console.ReadLine());
}