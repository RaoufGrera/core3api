
export { MainNav };
import { useState, useEffect,useRef  } from 'react';
import { useTranslation } from "react-i18next";



function MainNav({ show }) {
	const [isListOpen ,setIsListOpen ] = useState(false);
	const ref = useRef(null);


   
 	function toggleList () {	  
		setIsListOpen(!isListOpen)
	 }

	 const handleClickOutside = (event) => {
        if (ref.current && !ref.current.contains(event.target)) {
			setIsListOpen(false);
		        }
    };
	
	const listLang= {
		"ar":{
			"Login":"تسجيل الدخول"
		},
		"en":{
			"Login":"Login"
		}
	}


	 useEffect(() => {

		setTimeout(() => {
		if(isListOpen){
			window.addEventListener('click', handleClickOutside,true)
		  }
		  else{
			window.removeEventListener('click',handleClickOutside,true)
		  }
		})
	 },)

	 
	  
    return (

		<header className="logged">
			<h1 className="">
			<svg className='app-icon page-account-edit_profile' viewBox="0 0 96 96"><path fillRule="evenodd" clipRule="evenodd" d="M84.142 21.742L74.243 11.843C71.900 9.500 68.100 9.500 65.757 11.843L58.416 19.184C57.891 19.710 58.083 20.654 58.741 21.000C60.502 21.925 63.742 23.970 67.879 28.106C72.015 32.243 74.060 35.483 74.985 37.244C75.331 37.902 76.275 38.094 76.801 37.569L84.142 30.228C86.485 27.884 86.485 24.085 84.142 21.742ZM71.517 42.852L33.916 80.453C33.471 80.899 32.895 81.193 32.273 81.294L15.411 84.013C13.392 84.339 11.646 82.593 11.972 80.574L14.691 63.712C14.792 63.090 15.086 62.514 15.532 62.069L53.133 24.468C53.936 23.664 55.123 23.400 56.122 23.940C57.925 24.914 61.073 26.958 65.050 30.935C69.027 34.912 71.071 38.060 72.045 39.863C72.585 40.862 72.321 42.049 71.517 42.852ZM23.069 78.134L30.261 77.027C30.749 76.952 31.109 76.532 31.109 76.039L31.109 73.947C31.109 72.842 30.214 71.947 29.109 71.947H26.038C24.933 71.947 24.038 71.052 24.038 69.947L24.038 66.876C24.038 65.771 23.143 64.876 22.038 64.876L19.946 64.876C19.453 64.876 19.033 65.236 18.958 65.724L17.851 72.916C17.758 73.522 18.234 74.106 18.803 74.335C19.296 74.533 19.899 74.879 20.503 75.482C21.106 76.086 21.452 76.689 21.650 77.182C21.879 77.751 22.463 78.227 23.069 78.134Z"></path></svg>		تعديل الملف	</h1>
		 </header>
 
    );
}