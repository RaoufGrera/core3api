import Modal from 'react-modal';
import React, { useEffect, useRef, useState } from "react";
import { useForm } from 'react-hook-form';
import { useTranslation } from 'next-i18next'
import { accountService } from '../../src/_services'
import { ModalStamp } from './ModalStamp';
import getConfig from 'next/config';
import Link from 'next/link';
import { toast } from 'react-toastify';

const { publicRuntimeConfig } = getConfig();

export { ModalMessage }
function ModalMessage(props) {
  const { t } = useTranslation('common');

  const show = props.show;
  const change = props.change;
  const exit = props.exit;
  const user = props.user;



  const { handleSubmit } = useForm();
  function onSubmit(data) {
    // return updateUser(users.id, data);

    console.log("Sbumit data")
  }
  const [messageText, setMessageText] = useState("");
  const [count, setCount] = React.useState(0);
  const pattern = /[\u0600-\u06FF\u0750-\u077F]/;

  const [showModalMessage, setShowModalMessage] = useState(false);
  const [secret, SetSecret] = useState(getRandomInt(10));

  const [stamp, setStamp] = useState("/Stamp/deafult.png");
  function getRandomInt(max) {
    return Math.floor(Math.random() * max);
  }


  const changeStamp = (stamp) => {
    setStamp(stamp)

  }

  const handleCloseModalText = () => {

    setShowModalMessage(false);
  }
  function handleOpenModalMessage() {
    setShowModalMessage(true);
  }



  const handelChange = async (event) => {
    // return updateUser(users.id, data);

    event.preventDefault();
    // alert(`So your name is ${event.target.value}?`);

    if (user == null) {
      accountService.sendPublicMessage({ "RecipientUsername": "message", "Content": messageText, "Stamp": stamp, "CountChar": count, "Secret": secret }).then(result => {
        console.log("result", result)
        setMessageText("")
        setCount(0)
        toast.success(t('send_new_public_message'))

        change(result)
      });
    } else {
      accountService.sendMessage({ "RecipientUsername": "message", "Content": messageText, "Stamp": stamp, "CountChar": count, "Secret": secret }, user.id).then(result => {
        console.log("result", result)
        setMessageText("")
        toast.success(t('send_new_message'))
        setCount(0)

        change(result)
      });
    }
    exit();
    console.log("Sbumit")
  }
  const handleChangeText = (e) => {
    setMessageText(e.target.value)
    var matches = e.target.value.match(/\S+/g);
    //  return ;
    setCount(matches ? matches.length : 0)

  }



  return (
    <div>
      <Modal
        isOpen={show}
        contentLabel="onRequestClose Example"

        ariaHideApp={false}
        className="dialog-input open aside"
        overlayClassName="Overlay"
      >
        <div className='container-modal open '>



          <div id='headerMessage'>

            <div className="d-flex w-100 justify-content-between p-1 ">
              <div>
                <button onClick={exit} type="button" className="btn btn-danger ml-2 btn-120">{t('close')}</button>
              </div>
              <div className='p-2 ml-3'><span>
                {(user != null) ? t('private_message') : t('public_message')}</span>
              </div>
              <div>
                <button onClick={handelChange} type="button" className="btn btn-dark ml-2 btn-120">
                  <i className="icon-send mr-2"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-send" viewBox="0 0 16 16">
                    <path d="M15.854.146a.5.5 0 0 1 .11.54l-5.819 14.547a.75.75 0 0 1-1.329.124l-3.178-4.995L.643 7.184a.75.75 0 0 1 .124-1.33L15.314.037a.5.5 0 0 1 .54.11ZM6.636 10.07l2.761 4.338L14.13 2.576 6.636 10.07Zm6.787-8.201L1.591 6.602l4.339 2.76 7.494-7.493Z"></path>
                  </svg></i>
                  <span>{t('send')}</span>
                </button>

              </div></div>
          </div>
          <ModalStamp show={showModalMessage} exit={handleCloseModalText} change={(e) => { changeStamp(e) }} />

          <div dir="rtl" className="d-flex pt-2 px-3 align-items-center">
            {(user == null) &&
              <div className="d-flex align-items-center mt-n2">
                <div lang='ar' className="stamp-header-one"><div className="stamp-img"></div>LY</div>
              </div>
            }
            {(user != null) &&
              <div className="d-flex p-2 box-user ">

                <div className="mr-2">
                  <img src={`${process.env.imgUrl}/${user.image}`} className="p-1 border " alt="user logo" width="80" height="80" /></div>
                <div className="col "><div className="d-flex  text-truncate">
                  <p className="col pl-0 pr-0 mt-2 mb-0 text-black-100 fw-bold mx-2">{user.name}</p>
                </div><div className="text-black-50 d-flex p-0 m-0 align-items-center small text-truncate">
                    <p className="mt-1 box-age mx-1">{user.age}، {user.country}</p></div>

                </div>

              </div>
            }
            <div className="flex-grow-1 text-start">
              <button onClick={handleOpenModalMessage} className="btn btn-default pr-2">

                <img className="stamp loaded" width={100} src={`${process.env.imgUrl}/${stamp}`} />
              </button>
            </div>
          </div>
          <div className='center f-13'>
            <span className='stmsg'>{t('number_words')} : <span>{count}</span></span></div>
          <form className='form-msg' onSubmit={handleSubmit(onSubmit)}>
            <fieldset className='fade style-list'>

              <textarea className={pattern.test(messageText) ? "ar rtl" : "en ltr"} placeholder={t('simple_text')} onChange={handleChangeText} rows="9" value={(messageText) ? messageText : ""}  ></textarea>


            </fieldset>

          </form>


        </div>

      </Modal >
    </div >
  );

}