#include "problems.h"
#include "project.h"
#include "problem_state.h"

// CHECK IF NUMBER IS PRIME
bool is_prime(int NR) {
    int NRDIV = 0;
    for (int D = 1; D <= NR; D++) {
        if (NR % D == 0) {
            NRDIV++;
        }
    }
    if (NRDIV == 2) {
        return true;
    }
    return false;
}

// CHECK IF ITS ASCENDING
bool ascending_numbers(int** MATRIX, int ROW, int COL) {
    if (COL <= 1) {
        return false;
    }
    int PREV = MATRIX[ROW][0];
    // ///////////////////////
    for (int C = 0; C < (COL - 1); C++) {
        int CUR = MATRIX[ROW][C + 1];
        /////////////////////////
        if ((CUR - PREV) != 1) {
            return false;
        }
        PREV = CUR;
        continue;
    }
    return true;
}

/////////////////////////////////////////////////////////////////////////////

// CONVERT VECTOR TO STRING
std::string vector_to_str(std::vector<int> &VEC) {
    std::stringstream result;
    for (int I = 0; I < VEC.size(); I++) {
        if (I == (VEC.size() - 1)) {
            result << VEC[I] << ".";
        } else {
            result << VEC[I] << ", ";
        }
    }
    return result.str().c_str();
}

// PROBLEMA 9
void problems::problema9() {
    char str[1024];
    double PI, PF, N = 0;
    /////////////////////
    this->PROIECT->POPUP.show();
    this->PROIECT->P.PROBLEM_RUNNING = true;
    while (true) {
          std::cout << "Introduceti un numar real: "; std::cin >> N;
          if (!std::cin) {
              std::cout << "(!) Eroare: Trebuie sa introduceti un numar real, incercati din nou..." << std::endl;
              std::cin.clear();
              std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
              continue;
          } else {
              // CHECK IF INT
              if (floor(N) == ceil(N)) {
                  std::cout << "(!) Eroare: Trebuie sa introduceti un numar real nu un numar intreg!" << std::endl;
                  continue;
              }
              break;
          }
    }
    PI = (int)N;
    PF = N - PI;
    ////////////
    sprintf_s(str, "\tFormule de calcul utilizate in rezolvarea problemei:\n\t\t      PARTEA INTREAGA = (INT)NUMAR\n   PARTEA FRACTIONALA = NUMAR - PARTEA INTREAGA.\n\n\nNumarul real introdus de dumneavoastra este: %.2f.\nPartea intreaga a numarului real introdus este: %.2f.\nPartea fractionara a numarului real introdus este: %.2f.", N, PI, PF);
    this->PROIECT->POPUP.hide();
    std::cout << str << std::endl;
    // UPDATE RESULT TEXT
    this->PROIECT->P.PROBLEM_RUNNING = false;
    this->PROIECT->P.NEEDS_RESULT_UPDATE = true;
    this->PROIECT->P.RESULT_T_U = std::string(str);
    return;
}

// Problema 37
void problems::problema37() {
    int** MATRIX;
    char str[2012];
    int ROWCOUNT, COLCOUNT, P_V = 0;
    ////////////////////////////////
    this->PROIECT->POPUP.show();
    this->PROIECT->P.PROBLEM_RUNNING = true;
    // GET ROWCOUNT
    while (true) {
        std::cout << "Introduceti numarul de randuri: "; std::cin >> ROWCOUNT;
        if (!std::cin) {
            std::cout << "(!) Eroare: Trebuie sa introduceti un numar intreg, incercati din nou..." << std::endl;
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            continue;
        }
        if (ROWCOUNT <= 0) {
            std::cout << "(!) Eroare: Trebuie sa introduceti un numar mai mare de 0." << std::endl;
            continue;
        }
        if (ROWCOUNT > 5) {
            ROWCOUNT = 5;
            std::cout << "(!) Eroare: Numarul de randuri nu poate sa fie mai mare de 5." << std::endl;
        }
        break;
    }
    // GET COLCOUNT
    while (true) {
        std::cout << "Introduceti numarul de coloane: "; std::cin >> COLCOUNT;
        if (!std::cin) {
            std::cout << "(!) Eroare: Trebuie sa introduceti un numar intreg, incercati din nou..." << std::endl;
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            continue;
        }
        if (COLCOUNT <= 0) {
            std::cout << "(!) Eroare: Trebuie sa introduceti un numar mai mare de 0." << std::endl;
            continue;
        }
        if (COLCOUNT > 5) {
            COLCOUNT = 5;
            std::cout << "(!) Eroare: Numarul de coloane nu poate sa fie mai mare de 5." << std::endl;
        }
        break;
    }
    // DEFINE MATRIX AND EACH ROW
    MATRIX = new int* [ROWCOUNT];
    for (int i = 0; i < ROWCOUNT; ++i) {
        MATRIX[i] = new int[COLCOUNT];
    }
    // ENTER VALUES FOR EACH ROW
    for (int I = 0; I < ROWCOUNT; ++I) {
        int C = 0;
        std::cout << "R" << (I + 1) << ": ";
        while (C < COLCOUNT) {
            std::cin >> MATRIX[I][C];
            C += 1;
        }
    }
    // LOOP MATRIX
    std::vector<int> VECTOR;
    int LINII_CRESCATOARE = 0;
    /// //////////////////////
    for (int R = 0; R < ROWCOUNT; R++) {
        // CHECK IF THE LINE HAS ASCENDING NUMBERS
        if (ascending_numbers(MATRIX, R, COLCOUNT)) {
            LINII_CRESCATOARE += 1;
            VECTOR.push_back(R + 1);
        }
    }
    // SHOW RESULTS
    if (LINII_CRESCATOARE <= 0) {
        sprintf_s(str, "\tMatricea definita nu are linii cu elemente in ordine crescatoare.");
    } else if (LINII_CRESCATOARE == 1) {
        sprintf_s(str, "\tMatricea definita are o linie cu elemente in ordine crescatoare.\n    Aceasta linie fiind: %s", vector_to_str(VECTOR).c_str());
    } else {
        sprintf_s(str, "\tMatricea definita are %i linii cu elemente in ordine crescatoare.\n    Aceaste linii fiind: %s", LINII_CRESCATOARE, vector_to_str(VECTOR).c_str());
    }
    this->PROIECT->POPUP.hide();
    std::cout << str << std::endl;
    // UPDATE RESULT TEXT
    this->PROIECT->P.MATRIX_37 = MATRIX;
    this->PROIECT->P.COLNUMBER = COLCOUNT;
    this->PROIECT->P.ROWNUMBER = ROWCOUNT;
    this->PROIECT->P.PROBLEM_RUNNING = false;
    this->PROIECT->P.NEEDS_MATRIX_DRAW = true;
    this->PROIECT->P.NEEDS_RESULT_UPDATE = true;
    this->PROIECT->P.RESULT_T_U = std::string(str);
    return;
}

// Problema 4
void problems::problema4() {
    char str[2012];
    std::vector<int> VECTOR;
    int SUM_PARE = 0, SUM_IMPARE = 0, SUM_P_PARE = 0, SUM_P_IMPARE = 0;
    // ////////////////////////////////////////////////////////////////////////
    this->PROIECT->POPUP.show();
    this->PROIECT->P.PROBLEM_RUNNING = true;
    std::cout << "Introduceti numerele dorite, sa finalizati aceasta operatiune introduceti numarul 0." << std::endl;
    while (true) {
        int I;
        std::cin >> I;
        if (!std::cin) {
            std::cout << "(!) Eroare: Trebuie sa introduceti un numar intreg, incercati din nou..." << std::endl;
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            continue;
        }
        VECTOR.push_back(I);
        if (I == 0) {
            break;
        }
    }
    // SUM OF THE PAIR NUMBERS
    for (int I = 0; I < VECTOR.size(); I++) {
        int N = VECTOR.at(I);
        if ((N % 2) == 0) {
            SUM_PARE += N;
        }
    }
    // NUMERELE IMPARE
    for (int I = 0; I < VECTOR.size(); I++) {
        int N = VECTOR.at(I);
        if ((N % 2) != 0) {
            SUM_IMPARE += N;
        }
    }
    // NUMERELE DE PE POZITILE PARE
    for (int I = 0; I < VECTOR.size(); I += 2) {
        int N = VECTOR.at(I);
        SUM_P_PARE += N;
    }
    // NUMERELE DE PE POZITILE INPARE
    for (int I = 1; I < VECTOR.size(); I += 2) {
        int N = VECTOR.at(I);
        SUM_P_IMPARE += N;
    }
    // SHOW THE RESULT TO THE CONSOLE AND WINDOW
    sprintf_s(str, 
       "Vectorul introdus de dumneavoastra este:\n%s\n\nSuma elementelor pare din sir este: %i.\nSuma elementelor impare din sir este: %i.\nSuma elementelor de indice par din sir este: %i.\nSuma elementelor de indice impar din sir este: %i.\n"
    , vector_to_str(VECTOR).c_str(), SUM_PARE, SUM_IMPARE, SUM_P_PARE, SUM_P_IMPARE);
    this->PROIECT->POPUP.hide();
    std::cout << str << std::endl;
    // UPDATE RESULT TEXT
    this->PROIECT->P.PROBLEM_RUNNING = false;
    this->PROIECT->P.NEEDS_RESULT_UPDATE = true;
    this->PROIECT->P.RESULT_T_U = std::string(str);
    return;
}

// PROBLEMA 84
void problems::problema84() {
    int X = 0;
    char str[1024];
    ///////////////
    this->PROIECT->POPUP.show();
    this->PROIECT->P.PROBLEM_RUNNING = true;
    while (true) {
        std::cout << "Introduceti un numar prim: "; std::cin >> X;
        if (!std::cin) {
            std::cout << "(!) Eroare: Trebuie sa introduceti un numar prim, incercati din nou..." << std::endl;
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            continue;
        } else {
            // CHECK IF PRIME
            if (!is_prime(X)) {
                std::cout << "(!) Eroare: Trebuie sa introduceti un numar prim nu un numar intreg!" << std::endl;
                continue;
            }
            break;
        }
    }
    double a = 1, xa = 0, ERROR1 = 0.000001;
    ///////////////////////////////////////
    while (abs(a - xa) > ERROR1) {
        xa = a;
        a = 0.5 * (a + X / a);
        std::cout << a << std::endl;
    }
    // SHOW THE RESULT TO THE CONSOLE AND WINDOW
    sprintf_s(str, "\tRadicalul numarului prim %i este: %.2f.", X, a);
    this->PROIECT->POPUP.hide();
    std::cout << str << std::endl;
    // UPDATE RESULT TEXT
    this->PROIECT->P.PROBLEM_RUNNING = false;
    this->PROIECT->P.NEEDS_RESULT_UPDATE = true;
    this->PROIECT->P.RESULT_T_U = std::string(str);
    return;
}

// INITIALIZE THE PROBLEMS DATA
void problems::init() {
	assign(P_9, 9, "Problema 9", "Sa se scrie un program care calculeaza partea intreaga si partea \n fractionara a unui numar real, fara a se utiliza functii de biblioteca..", "             Problema asteapta un numar real pentu a rula,\nduceti-va la consola asociata programului si introduceti un numar real.");
	assign(P_84, 84, "Problema 84", "     Sa se extraga radicalul dintr-un numar prim X utilizand algoritmul lui Newton. \n a[k+1] = 0.5 * (a[k] + x/a[k]). Sirul a este convergent, iar limita sirului este sqrt(x).", "             Problema asteapta un numar prim pentu a rula,\nduceti-va la consola asociata programului si introduceti un numar prim.");
	assign(P_4, 4, "Problema 4", "     Se da un sir de numere terminat cu 0. Sa se insumeze elementele \n pare si cele impare si elementele de indice par si cele de indice impar din sir.", "    Problema asteapta un sir de valori pentu a rula, duceti-va\nla consola asociata programului si introduceti cate numere doriti,\n     introducerea se va finaliza odata ce introduceti numarul 0.");
	assign(P_37, 37, "Problema 37", "Sa se numere liniile unei matrici ale caror elemente sunt in ordine crescatoare.\n", "         Problema asteapta doua numere intregi pentu a rula,\n  un numar pentru coloane si unul pentru numarul de randuri, duceti-va\nla consola asociata programului si introduceti doua numere intregi.");
    return;
}
