#include "main.h"

// PRINT HEADER MENU
void UTIL::utils::print_menu() {
	std::cout << std::endl;
	std::cout << "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-" << std::endl;
	std::cout << "-=-=-=-=-=-= PROIECT ATP -=-=-=-=-=" << std::endl;
	std::cout << "-=-=- FLOREA CLAUDIU VALENTIN -=-=-" << std::endl;
	std::cout << "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-" << std::endl;
	std::cout << "1. Problema 37 - Sa se numere liniile unei matrici ale caror elemente sunt in ordine crescatoare." << std::endl;
	std::cout << "2. Problema 9 - Sa se scrie un program care calculeaza partea intreaga si partea fractionara a unui numar real, fara a se utiliza functii de biblioteca.." << std::endl;
	std::cout << "3. Problema 4 - Se da un sir de numere terminat cu 0. Sa se insumeze elementele pare si cele impare si elementele de indice par si cele de indice impar din sir." << std::endl;
	std::cout << "4. Problema 84 - Sa se extraga radicalul dintr-un numar prim X utilizand algoritmul lui Newton. a[k+1] = 0.5 * (a[k] + x/a[k]). Sirul a este convergent, iar limita sirului este sqrt(x)." << std::endl;
	std::cout << std::endl;
	return;
}

// CREATE TEXT
void UTIL::utils::text(sf::Text &TEXT, sf::Vector2f POSITION, sf::String T, sf::Color TEXT_COLOR) {
	return text(TEXT, POSITION, T, TEXT_COLOR, sf::Color::Black, this->MAIN->PROIECT.ARIAL_FONT, 2.0f);
}

void UTIL::utils::text(sf::Text& TEXT, sf::Vector2f POSITION, sf::String T, sf::Color TEXT_COLOR, sf::Color OUT_COLOR) {
	return text(TEXT, POSITION, T, TEXT_COLOR, OUT_COLOR, this->MAIN->PROIECT.ARIAL_FONT, 2.0f);
}

void UTIL::utils::text(sf::Text& TEXT, sf::Vector2f POSITION, sf::String T, sf::Color TEXT_COLOR, sf::Color OUT_COLOR, sf::Font F) {
	return text(TEXT, POSITION, T, TEXT_COLOR, OUT_COLOR, F, 2.0f);
}

void UTIL::utils::text(sf::Text& TEXT, sf::Vector2f POSITION, sf::String T, sf::Color TEXT_COLOR, sf::Color OUT_COLOR, sf::Font F, float THICKNESS) {
	TEXT.setFont(F);
	TEXT.setString(T);
	TEXT.setPosition(POSITION);
	TEXT.setFillColor(TEXT_COLOR);
	TEXT.setOutlineColor(OUT_COLOR);
	TEXT.setOutlineThickness(THICKNESS);
	return;
}