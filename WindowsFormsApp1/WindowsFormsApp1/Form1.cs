using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //My new branch
            //배돌 배용진 baedole
            Calculation();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            string s_num = textBox_input.Text;
            int i_num = 0;
            // 성공하면 s_num을 int로 반환해서 i_num이 숫자면 반환(out), 아니면 false 반환 
            /*            if (int.TryParse(s_num,out i_num))
                        {
                            textBox_print.Text = (i_num + 100).ToString();
                        }
                        else
                        {
                            MessageBox.Show("숫자를 입력해주세요.");
                        }*/

            //textBox_print.Text = textBox_input.Text;
        }


        private string Calculation()
        {
            /*
            • Form1 클래스에 Calculation 메소드를 만들기
            • Form1 생성자에서 함수 실행(InitializeComponet() 밑에 작성)
            • 결과를 텍스트 박스에 출력
            • 모든 계산 결과에는 "계산 완료" 메시지를 추가
            • 오류 발생시 메시지 박스로 출력하기
            • 0으로 나눌 경우 오류처리 */
            /*1+1형태로 입력받았을 때.
            문자열 배열로 저장. 2번쨰[1] 인덱스를 참조. 이걸로 어떻게 계싼할지.
            스위치문.*/

            string input = textBox_input.Text;
            string[] inputarray = new string[2];
            int result = 0;

            if (input.Contains('+')) {
                inputarray = input.Split('+');
            }
            if (input.Contains('-'))
            {
                inputarray = input.Split('-');
            }
            if (input.Contains('*'))
            {
                inputarray = input.Split('*');
            }
            if (input.Contains('/'))
            {
                inputarray = input.Split('/');
            }

            switch (inputarray[1])
            {
                case "+":
                    result = int.Parse(inputarray[0]) + int.Parse(inputarray[2]);
                    break;
                case "-":
                    result = int.Parse(inputarray[0]) - int.Parse(inputarray[2]);
                    break;
                case "*":
                    result = int.Parse(inputarray[0]) * int.Parse(inputarray[2]);
                    break;
                case "/":
                    result = int.Parse(inputarray[0]) / int.Parse(inputarray[2]);
                    break;
            }
            return textBox_print.Text = result.ToString();

        }
    }
}
