import { ICallOverlayHandler, IAddOverlayListener } from '../';

declare global {
  const callOverlayHandler: ICallOverlayHandler;
  const addOverlayListener: IAddOverlayListener;
}
