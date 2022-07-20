#pragma once
#include "general.h"
class project;

class problems {
public:
	struct main_problem {
		int ID = 0;
		std::string NUME;
		std::string DESC;
		std::string INSTRUCTION;
	};
	project* PROIECT = nullptr;
	main_problem P_9, P_84, P_4, P_37;
	problems() {}
	problems(project* PR) {
		PROIECT = PR;
		init();
	}
	// INIT
	void init();
	// GET PROBLEM INSTANCE BY ID
	main_problem get_by_number(int NR) {
		switch (NR) {
		case 1:
			return P_9;
		case 2:
			return P_84;
		case 3:
			return P_4;
		case 4:
			return P_37;
		}
	}
	// GET PROBLEM INSTANCE BY ID
	main_problem get_by_id(int ID) {
		switch (ID) {
		case 9:
			return P_9;
		case 84:
			return P_84;
		case 4:
			return P_4;
		case 37:
			return P_37;
		}
	}
	// EXECUTE PROBLEM INSTANCE BY ID
	void execute_by_id(int ID) {
		switch (ID) {
		case 9:
			problema9();
			break;
		case 84:
			problema84();
			break;
		case 4:
			problema4();
			break;
		case 37:
			problema37();
			break;
		}
	}
private:
	// ASSIGN VALUES
	void assign(main_problem &P, int ID, std::string NAME, std::string DESC, std::string INS) {
		P.ID = ID;
		P.DESC = DESC;
		P.NUME = NAME;
		P.INSTRUCTION = INS;
	}
	void problema9();
	void problema37();
	void problema4();
	void problema84();
};

