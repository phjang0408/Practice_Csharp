using System;
using System.IO;
using System.Linq;
// File, Directory : 정적 클래스, File. 등으로 객체 생성하지않고 사용, 단순한 작업
// FileInfo, DirectoryInfo : 인스턴스 클래스, new로 객체 생성 후 사용, 크기, 속성, 이동하는 '연속적 작업'에 사용
namespace MySpace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
            {
                directory = "."; // 인자가 없으면 현재 디렉토리 지정
            }
            else
            {
                directory = args[0]; // 인자가 있으면 해당 경로 지정
            }
            Console.WriteLine($"{directory} directory Info");
            Console.WriteLine("- Directories : ");

            // =======================================================================
            // [하위 디렉토리 목록 조회]
            // 비교 포인트: 
            // 1. Directory.GetDirectories() -> 단순 문자열 경로(string)만 배열로 빠르게 가져옵니다.
            // 2. new DirectoryInfo(dir)     -> 가져온 문자열 경로를 기반으로 '인스턴스 객체'를 생성합니다.
            //                                  이를 통해 전체 경로가 아닌 실제 폴더명(Name)이나 속성(Attributes)에 쉽게 접근합니다.
            // =======================================================================
            var directories = (from dir in Directory.GetDirectories(directory)  // from 'x' in 'y' => 'y'경로에서, 하나씩 꺼내, 임시변수 'dir에 저장
                                let info = new DirectoryInfo(dir) // let => dir을 원하는 형식(DirectoryInfo)으로 가공 후 중간 변수로 저장, 여기선 정적 정보(string)를 인스턴스 객체로 변환
                                select new                        // select => 가공된 객체(info)들에서 필요한것만 선택하여 또 가공
                                {
                                    Name = info.Name,             // 전체 경로 중 최종 폴더 이름만 추출
                                    Attributes = info.Attributes  // 폴더의 속성(숨김, 시스템, 디렉토리 등) 추출
                                }).ToList();

            foreach(var d in directories)
                Console.WriteLine($"{d.Name} : {d.Attributes}");

            // =======================================================================
            // [하위 파일 목록 조회]
            // 비교 포인트:
            // 1. Directory.GetFiles() -> 해당 폴더 내 파일들의 단순 문자열 경로만 배열로 가져옵니다.
            // 2. new FileInfo(file)    -> 파일 문자열 경로를 'FileInfo 인스턴스 객체'로 만듭니다.
            //                             단순 문자열 상태에서는 알 수 없는 파일 크기(Length)나 파일명(Name)을 
            //                             객체의 프로퍼티를 통해 손쉽게 조회할 수 있게 됩니다.
            // =======================================================================
            Console.WriteLine("- Files : ");
            var files = (from file in Directory.GetFiles(directory)
                        let info = new FileInfo(file) // 정적 정보(string)를 인스턴스 객체로 변환
                        select new
                        {
                            Name = info.Name,             // 파일명과 확장자만 추출
                            FileSize = info.Length,       // 파일 크기(Byte 단위) 추출
                            Attributes = info.Attributes  // 파일의 속성 추출
                        }).ToList();
                        
            foreach (var f in files)
                Console.WriteLine($"{f.Name} : {f.FileSize}, {f.Attributes}");
        }
    }
}