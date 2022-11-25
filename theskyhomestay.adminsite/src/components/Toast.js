import Toast from 'react-bootstrap/Toast';
import { useState } from "react";

function ToastMessage() {
    const [showToast, setToast] = useState(true);
  return (
    <>
      {[
        'Success',
        'Danger',
        'Warning',
      ].map((variant, idx) => (
        <Toast
            className="d-inline-block m-1"
            bg={variant.toLowerCase()}
            key={idx}
            onClose={() => setToast(false)}
            autohide
            show={true}
            delay={2200}
        >
          <Toast.Header>
            <img
              src="holder.js/20x20?text=%20"
              className="rounded me-2"
              alt=""
            />
            <strong className="me-auto">Bootstrap</strong>
            <small>11 mins ago</small>
          </Toast.Header>
          <Toast.Body className={variant === 'Dark' && 'text-white'}>
            Hello, world! This is a toast message.
          </Toast.Body>
        </Toast>
      ))}
    </>
  );
}

export default ToastMessage;