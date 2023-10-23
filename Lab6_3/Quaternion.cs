namespace Lab6_3
{
    using System;

    class Quaternion
    {
        public double a, b, c, d;

        public Quaternion(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static Quaternion operator +(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.a + q2.a, q1.b + q2.b, q1.c + q2.c, q1.d + q2.d);
        }

        public static Quaternion operator -(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.a - q2.a, q1.b - q2.b, q1.c - q2.c, q1.d - q2.d);
        }

        public static Quaternion operator *(Quaternion q1, Quaternion q2)
        {
            double a = q1.a * q2.a - q1.b * q2.b - q1.c * q2.c - q1.d * q2.d;
            double b = q1.a * q2.b + q1.b * q2.a + q1.c * q2.d - q1.d * q2.c;
            double c = q1.a * q2.c - q1.b * q2.d + q1.c * q2.a + q1.d * q2.b;
            double d = q1.a * q2.d + q1.b * q2.c - q1.c * q2.b + q1.d * q2.a;
            return new Quaternion(a, b, c, d);
        }

        public double Norm()
        {
            return Math.Sqrt(a * a + b * b + c * c + d * d);
        }

        public Quaternion Conjugate()
        {
            return new Quaternion(a, -b, -c, -d);
        }

        public Quaternion Inverse()
        {
            double normSquared = a * a + b * b + c * c + d * d;
            return new Quaternion(a / normSquared, -b / normSquared, -c / normSquared, -d / normSquared);
        }

        public static bool operator ==(Quaternion q1, Quaternion q2)
        {
            return q1.a == q2.a && q1.b == q2.b && q1.c == q2.c && q1.d == q2.d;
        }

        public static bool operator !=(Quaternion q1, Quaternion q2)
        {
            return !(q1 == q2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Quaternion)
            {
                Quaternion other = (Quaternion)obj;
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return a.GetHashCode() ^ b.GetHashCode() ^ c.GetHashCode() ^ d.GetHashCode();
        }

        public Matrix3x3 ToMatrix()
        {
            double aa = a * a;
            double bb = b * b;
            double cc = c * c;
            double dd = d * d;
            double ab = a * b;
            double ac = a * c;
            double ad = a * d;
            double bc = b * c;
            double bd = b * d;
            double cd = c * d;

            double[,] matrixData = new double[3, 3]
            {
            { aa + bb - cc - dd, 2 * (bc - ad), 2 * (ac + bd) },
            { 2 * (ad + bc), aa - bb + cc - dd, 2 * (cd - ab) },
            { 2 * (bd - ac), 2 * (ab + cd), aa - bb - cc + dd }
            };

            return new Matrix3x3(matrixData);
        }

        public static Quaternion FromRnMatrix(Matrix3x3 matrix)
        {
            double trace = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
            double S;

            if (trace > 0)
            {
                S = 0.5 / Math.Sqrt(trace + 1.0);
                return new Quaternion(
                    0.25 / S,
                    (matrix[2, 1] - matrix[1, 2]) * S,
                    (matrix[0, 2] - matrix[2, 0]) * S,
                    (matrix[1, 0] - matrix[0, 1]) * S
                );
            }
            else if (matrix[0, 0] > matrix[1, 1] && matrix[0, 0] > matrix[2, 2])
            {
                S = 2.0 * Math.Sqrt(1.0 + matrix[0, 0] - matrix[1, 1] - matrix[2, 2]);
                return new Quaternion(
                    (matrix[2, 1] - matrix[1, 2]) / S,
                    0.25 * S,
                    (matrix[0, 1] + matrix[1, 0]) / S,
                    (matrix[0, 2] + matrix[2, 0]) / S
                );
            }
            else if (matrix[1, 1] > matrix[2, 2])
            {
                S = 2.0 * Math.Sqrt(1.0 + matrix[1, 1] - matrix[0, 0] - matrix[2, 2]);
                return new Quaternion(
                    (matrix[0, 2] - matrix[2, 0]) / S,
                    (matrix[0, 1] + matrix[1, 0]) / S,
                    0.25 * S,
                    (matrix[1, 2] + matrix[2, 1]) / S
                );
            }
            else
            {
                S = 2.0 * Math.Sqrt(1.0 + matrix[2, 2] - matrix[0, 0] - matrix[1, 1]);
                return new Quaternion(
                    (matrix[1, 0] - matrix[0, 1]) / S,
                    (matrix[0, 2] + matrix[2, 0]) / S,
                    (matrix[1, 2] + matrix[2, 1]) / S,
                    0.25 * S
                );
            }
        }
    }
}
