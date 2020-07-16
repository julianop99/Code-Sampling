#include <Eigen/Dense>
#include <iostream>

using namespace Eigen;
using namespace std;

int main()
{
	//Dynamic - resizable
	//Eigen::MatrixXd m; --> using namespace replaces the usage of Eigen:: every time
	MatrixXd m, d;

	// Fixed Sized Matrix
	//Matrix4d f;
	Matrix3d f, e;

	Matrix<float, 1,2> m1;
	Matrix<float, 2, 2> m2;

	VectorXf m4(2);

	f = Matrix3d::Random();

	e = Matrix3d::Constant(1.0);

	//d = MatrixXd::Random(5, 5);
	d = MatrixXd::Constant(5, 5, 1.0);

	m1 << 1, 2;
	m2 << 1, 2,
		3, 4;

	MatrixXf m3 = m1 * m2;

	MatrixXf m5 = m4.transpose() * m2;

	MatrixXf m6 = m1.array() + 1;

	MatrixXf m7 = exp(m1.array());


	//f.resize(5, 5);

	f.size();

	/*f << 1, 2, 3,
		4, 5, 6,
		7, 8, 9;*/

//	std::cout << f.size() << std::endl;
	std::cout << f << std::endl;
	cout << endl;
	std::cout << d << std::endl;
	cout << endl;
	std::cout << e << std::endl;
	cout << endl;
	std::cout << m3 << std::endl;
	cout << endl;
	std::cout << m5 << std::endl;
	cout << endl;
	std::cout << m6 << std::endl;
	cout << endl;
	std::cout << m7 << std::endl;

	std::cin.get();



}
