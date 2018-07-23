#pragma once
#include <windows.h>

void move_cursor(int x, int y)
{
	COORD pos = { x, y };
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), pos);
}

void cursor_hide(void)
{
	HANDLE hConsole; // �ܼ� �ڵ�
	CONSOLE_CURSOR_INFO ConsoleCursor; // �ܼ�Ŀ�� ���� ����ü

	hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // �ڵ��� ���ϰ�

	ConsoleCursor.bVisible = false; // true ���� , false �Ⱥ���
	ConsoleCursor.dwSize = 1; // Ŀ�� ������

	SetConsoleCursorInfo(hConsole, &ConsoleCursor);
}